#!/usr/bin/python

class Jobs:
   'Common base class for all Job seekers'
   JseekerCount = 0

   def __init__(self, name, tech):
      self.name = name
      self.tech = tech
      Jobs.JseekerCount += 1
   
   def displayCount(self):
     print ("Total Job Seekers %d" % Jobs.JseekerCount)

   def displayJobs(self):
      print ("Name : ", self.name,  ", Technology: ", self.tech)

"This would create first object of Employee class"
emp1 = Jobs("harshitha",".Net")
"This would create second object of Employee class"
emp2 = Jobs("Rashmi", "UI")
emp3 = Jobs("divya", "QA")
emp1.displayJobs()
emp2.displayJobs()
emp3.displayJobs()

print ("Total Job seekers %d" % Jobs.JseekerCount)
