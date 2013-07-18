# AnimalMaker 

This contains the completed solution & associate documentation for the 'AnimalMaker' project ( C# Web Developer position @ MYOB - 2013 July )
- Owner : Dinesh Wickramaratne [[email]](mailto:dineshw@gmail.com)
- Date : 17-07-2013


## Project Documentation

Project documentation can be found in the 'docs' folder. This contain the following documents

* <b>TestCases.docx</b>		: Contains the complet set of test cases associated with the project along with descriptions, test scenarios, expected results etc.
* <b>ProjectOverview.docx</b> 	: Contains the project overview of the solution including functional overview, non-funcitonal requirements, assumptions and proposals for future enhancements.

## Testing & Build integration

* <b>Unit testing framework</b> : NUnit  (version 2.6.2)
* <b>Build Tool(s)</b> : Rake (version 0.9.2.2) / Ruby (version 2.0.0p247 -64bit)
* <b>Rake tasks to Build/Test the solution </b> :

 Build Solution (in debug mode) :
```
 rake build:build[debug]
```
Run all unit tests : 
```
 rake test:all
```
	
### Links

* http://rake.rubyforge.org/
* http://rubyinstaller.org/downloads/
* https://github.com/Albacore/albacore
* http://www.stuartellis.eu/articles/rake/#installing-rake
* http://jasonseifer.com/2010/04/06/rake-tutorial
