#!/usr/bin/python

import MySQLdb

# Open database connection
db = MySQLdb.connect("localhost","root","","student" )

# prepare a cursor object using cursor() method
cursor = db.cursor()

# Prepare SQL query to INSERT a record into the database.
sql = """INSERT INTO `student_table` 
	(`student_id`, `student_name`, `student_father_name`, `student_age`, `subjects`, `class`) 
	VALUES (NULL, '%s', '%s', '%d', '%d', '%d')""" % (sname,sfather,12,2,1) 
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