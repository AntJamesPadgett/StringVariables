
//hungarian notation strFirstName---- Pascal casing FirstName --- camel casing firstName//
//Delcaration and optional assignment//
string firstName = string.Empty;
string lastName = string.Empty;
string filePath = string.Empty;

// If its one name.. still small casing
//Declaration///
firstName = "Tony";
lastName = "Padgett";
//filePath = "C:\\temp\\demo";
filePath = @"C:\temp\demo";
//firstName = "123";

//Console.WriteLine(firstName + " " Lastname);

string testString = $@"The file for {firstName} {lastName} is at C:\sampleFiles";

//string interpolation
Console.WriteLine($"{firstName} {lastName}");
Console.WriteLine(filePath);
Console.WriteLine(testString);
