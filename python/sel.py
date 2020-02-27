#!/usr/bin/python

import MySQLdb

# Open database connection
db = MySQLdb.connect("localhost","root","","student" )

# prepare a cursor object using cursor() method
cursor = db.cursor()

sql = "SELECT * FROM student_table" 
       #WHERE class like '%d'" % (4)
try:
   # Execute the SQL command
   cursor.execute(sql)
   # Fetch all the rows in a list of lists.
   results = cursor.fetchall()
   for row in results:
      studentid = row[0]
      sname = row[1]
      sfather = row[2]
      sage = row[3]
      subj = row[4]
      sclass = row[5]
      # Now print fetched result
      print ("id=%d,name=%s,father=%s,age=%d,subj=%d, class=%d") % \
             (studentid, sname, sfather, sage, subj,sclass )
except:
   print ("Error: unable to fecth data")

# disconnect from server
db.close()