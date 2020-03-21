using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management; 

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

private void DeviceInsertedEvent(object sender, EventArrivedEventArgs e)
    {
        txtData.Text = "inserted";
        ManagementBaseObject instance = (ManagementBaseObject)e.NewEvent["TargetInstance"];
        foreach (var property in instance.Properties)
        {
            txtData .Text =(property.Name + " = " + property.Value);
        }
    }

    private void DeviceRemovedEvent(object sender, EventArrivedEventArgs e)
    {
            txtData.Text = " removed";
            ManagementBaseObject instance = (ManagementBaseObject)e.NewEvent["TargetInstance"];
        foreach (var property in instance.Properties)
        {
            txtData.Text =(property.Name + " = " + property.Value);
        }
    }

    private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
        WqlEventQuery insertQuery = new WqlEventQuery("SELECT * FROM __InstanceCreationEvent WITHIN 2 WHERE TargetInstance ISA 'Win32_USBHub'");

        ManagementEventWatcher insertWatcher = new ManagementEventWatcher(insertQuery);
        insertWatcher.EventArrived += new EventArrivedEventHandler(DeviceInsertedEvent);
        insertWatcher.Start();

        WqlEventQuery removeQuery = new WqlEventQuery("SELECT * FROM __InstanceDeletionEvent WITHIN 2 WHERE TargetInstance ISA 'Win32_USBHub'");
        ManagementEventWatcher removeWatcher = new ManagementEventWatcher(removeQuery);
        removeWatcher.EventArrived += new EventArrivedEventHandler(DeviceRemovedEvent);
        removeWatcher.Start();

        // Do something while waiting for events
        System.Threading.Thread.Sleep(20000000);
    }


}
}
