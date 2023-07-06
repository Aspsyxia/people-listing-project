# People listing project
A very simple project I made for OOP class that covers very basic OOP, unit tests and saving data to a file. It allows to create person objects with few attributes and save them to file in specified format.
## What is PESEL
According to wikipedia definition, PESEL is the national identification number used in Poland. The number is 11 digits long, identifies exactly one person, and cannot be changed once assigned, except in specific situations (such as gender reassignment).
In this project it adds a little complexcity, cause PESEL has to be valid in order to add person to a list.
## How it works
User gives parameters of person in "name surname city PESEL" format, and if everything is fine, person gets added to a list. If anything is wrong user will get notified and will be asked to input data again.
If user gives some parameters with PESEL that already exists in a list, it will replace the old one (if it's correct).

Also, worth pointing out that list resets every time user runs the program - it's due to the project's specification.
