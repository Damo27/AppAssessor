-------------AppAssessor readme-------------------
--------------------1.2---------------------------
Additions:
	Assess Interfaces:
		Added assess interfaces option to the home screen form which will navigate to the Interface Assessor form.
		The form has the option to load assembly which will open a dialog to select an assembly in which to assess
		interfaces. The two list views will be populated, 1 with all the interfaces in the chosen assembly and 2
		dynamically with all the classes in the assembly which implement the selected interface from list view 1.
		Interfaces are displayed according to compliancy and implementation and are ordered alphabetically.

	Test 3 (Interfaces):
		Two assemblies namely MonkeyPuzzleMaker and OOPConcepts are found in test 3. OOPConcepts is an assembly 
		which was chosen as it contains many interfaces with various degrees of implementation. MonkeyPuzzleMaker
		has been seen before in Test 1 it has now however been altered to contain a number of test interfaces and
		test classes, using sufficient variation in naming convention and interface implementation to display all
		variations of compliance in the Interface Assessor form. Please note compliance is based on the currently 
		set, default Regular Expression to match with Camel Case.

	App Assessor HTG:
		The App Assessor How To Guide is a detailed explanation of each function of each form in the application.

	InterfaceAssessment Model:
		This model has properties for an assembly and two generic lists of Type <Type> called classes and interfaces.
		A constructor accepts an assembly name as a string and loads the specific assembly into the assembly property.
		The two lists are then populated based on the assembly, classes holding all the classes in the assembly and 
		interfaces the interfaces. 

		The reason for these generic lists is to query them using LINQ in order to obtain all the classes implementing
		a specific interface and to determine whether an interface has been implemented at all.

Changes:
	Assess Classes:
		Reduced the number of list views to 1 which instead of list 1 showing all classes which are compliant with 
		the user defined average number of lines per method and list 2 showing which are not, the list shows all 
		classes and visually distinguishes compliant from non-compliant with colours. Green for compliant, red for
		non-compliant.

	Settings:
		Added two textboxes for the user to configure compliancy settings based on their company requirements namely, 
		average number of lines per method and regular expression for interface naming convention. Added the save 
		button which gives the option to save or cancel. 

	User Interface:
		Made the general interfaces more "pretty". Fixed grammar and spelling in places. Fixed error handling issues 
		where the user would try filter or select before a assembly was loaded.
		
--------------------1.1---------------------------
Run:
	To run the AppAssessor, extract the AppAssessor.zip folder to a destination of your choice. You may then either open
	the solution (AppAssessor.sln) inside the zipped folder using Visual Studio and start the application, or you may 
	navigate to ~AppAssessor\AppAssessor\bin\Debug and run the AppAssessor.exe file.
	The application will open onto a Home page listing three options:
	
	Assess Assembly:
		Will open the AssessAssembly form. The form has the option to Load a single assembly which will open a file 
		dialog and extract the relevant data into the three lists. The user may then select an item from the Classes
		list in order to view its methods in the methods list. Methods may be filtered by All, Abstract, Constructor, 
		Private, Public, Static or Virtual. Display names can be toggled to full names or short names.

	Assess Class:
		Will open the AssessClass form. The form has the option to load multiple classes, the button will open a file 
		dialog and extract relevant data into the two lists. The user has the option to add more classes to the 
		assessment, and to alter the number of lines they would like to set as the standard to measure the methods
		against. The number of lines will be stored in the application config file and will therefore remain the 
		standard until changed.

	Settings:
		Implemented as a stub in iteration 1.1, will hold configuration settings at a later stage of development.

Data Structures:
_________________________________________________________AssemblyAssessor Model______________________________________________
	In the AssemblyAssesment model a generic list of type Type was used to hold all the classes inside the Assembly.
	Although the Types are initially extracted from the Assembly in the form of an Array, the array is immediately
	converted into a generic list so Language Integrated Queries (LINQ) may be used to easily extract only the necessary
	data and sort it alphabetically rather than itterating through the each item of the Array for the same result.
	This proves far more efficient and timeous.

	The Assembly Names of all external references are also extracted in the form of an array and immediately converted 
	into a generic list of type AssemblyName for the same reasons.
	
	Another reason for this data being stored in generic lists is that it may then be displayed in a ListView as a data
	source rather than each item being added one by one.

__________________________________________________________ClassAssessment Model_____________________________________________
	The ClassAssessment model is essentially just integer properties used to determine the average number of lines in 
	a given classes methods. To populate these properties it is necessary to see whether a line contains only whitespace,
	double forward slashes or certain keywords, therefore we need to itterate over each line in the .cs file and see 
	whether it contains the substring. As the lines are extracted as a string array and itteration of the data is forced,
	the data structure was kept as an array as convertion would be a waste of resources.

Test Data:
	Both Tests are comprised of a single assembly and a folder of classes (.cs files) as the application is intended to 
	assess Assemblies and Classes seperately. The test classes of course correlate to the test assembly, and are all the
	explicitly programmed classes of the test assembly.Therefore, all the test classes will be seen when assessing the 
	assembly. 
	To run a test Navigate to the AssessAssembly form and select Load Assembly, in the openFileDialog navigate
	to the test folder and select the assembly. 

		The ListViews will then populate with the relevant data:
			-alphabetical list of External References
			-All Classes sorted by number of methods (descending)
			-All Methods in the selected class sorted alphabetically

	Next navigate to the AssessClasses form and select Load Classes, in the openFileDialog navigate to the test folder,
	classes and select all the classes. Note additional classes may be loaded after the initial selection.
		
		The Listviews then populate with the relevant data:
			-List of compliant classes sorted by average lines per method (descending)
			-List of compliant classes sorted by average lines per method (descending)
	

__________________________________________________________________Test 1____________________________________________________
	Test 1 is comprised of a Windows Forms application assembly and the corresponding classes. The assembly was chosen as
	it contains both object classes and form classes which hold many auto generated methods. This makes the test data 
	extremely diverse and the application is large enought that the differences and similarities between classes can be 
	easily recognised.

__________________________________________________________________Test 2____________________________________________________
	Test 2 is comprised of a Windows Presentaion Foundation application assembly and the corresponding classes. The 
	assembly was chosen because it fulfills the exact same use case as the assembly from Test 1 but using a different
	graphical subsystem, and therefore useful to point out the differences in classes and assemblies between the two.