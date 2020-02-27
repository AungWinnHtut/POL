#INSERT INTO `student_table` (`student_id`, `student_name`, `student_father_name`, `student_age`, `subjects`, `class`) VALUES (NULL, 'hla hla', 'mg ba', '24', '3', '4');
#!/usr/bin/python

import MySQLdb

sname = "aung win"
sfather = "U maung"
sage = 34
subj = 1
sclass = 4

# Open database connection
db = MySQLdb.connect("localhost","root","","student" )

# prepare a cursor object using cursor() method
cursor = db.cursor()

# Prepare SQL query to INSERT a record into the database.
sql = """INSERT INTO `student_table` 
	(`student_id`, `student_name`, `student_father_name`, `student_age`, `subjects`, `class`) 
	VALUES (NULL, '%s', '%s', '%d', '%d', '%d');""" % (sname,sfather,sage,subj,sclass)
try:
   # Execute the SQL command
   cursor.execute(sql)
   # Commit your changes in the database
   db.commit()
except:
   # Rollback in case there is any error
   db.rollback()

# disconnect from server
db.close()