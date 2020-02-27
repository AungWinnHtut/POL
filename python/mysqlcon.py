import mysql.connector

mydb = mysql.connector.connect(
  host="localhost",
  user="root",
  passwd="",
  database="student"
)

mycursor = mydb.cursor()
fname="mg ba"
mycursor.execute("SELECT * FROM student_table where student_father_name = '%s'" % (fname))

myresult = mycursor.fetchall()

  
for row in myresult:
	studentid = row[0]
	sname = row[1]
	sfather = row[2]
	sage = row[3]
	subj = row[4]
	sclass = row[5]
	# Now print fetched result
	print ("id=%d,name=%s,father=%s,age=%d,subj=%d, class=%d" % (studentid, sname, sfather, sage, subj,sclass ))