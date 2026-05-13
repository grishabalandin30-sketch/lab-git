using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class DigitRecorder
{
    static void Main()
    {
        string filePath = "feature.txt";
        
        try
        {
            // Read the entire file content
            string content = File.ReadAllText(filePath);
            
            // Extract all digits from the content
            string digits = Regex.Replace(content, @"[^\d]", "");
            
            // Display the digits found
            Console.WriteLine("Digits found in feature.txt:");
            Console.WriteLine(digits);
            
            // Save digits to a file
            File.WriteAllText("digits.txt", digits);
            Console.WriteLine("\nDigits saved to digits.txt");
            
            // Display statistics
            Console.WriteLine($"\nTotal digits found: {digits.Length}");
            
            // Display unique digits
            var uniqueDigits = digits.Distinct().OrderBy(c => c);
            Console.WriteLine($"Unique digits: {string.Join(", ", uniqueDigits)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

//I need an app that reads feature.txt and records all the digits in this app.

/*I'll help you create an app that reads feature.txt and records all the digits. Let me first check the existing files to understand what we're working with.  

Read [](file:///d%3A/lab_5_git/lab-git/txtreader.cs)

Read [](file:///d%3A/lab_5_git/lab-git/feature.txt)

I can see that feature.txt appears to be a text file with special encoding, and txtreader.cs is empty. I'll create a C# application that reads feature.txt and extracts all digits from it. Let me update the txtreader.cs file: 

Created [](file:///d%3A/lab_5_git/lab-git/txtreader.cs)

Done! I've created a C# application in txtreader.cs that:

1. **Reads feature.txt** - Opens and reads the entire file content
2. **Extracts all digits** - Uses regex to find all digit characters (0-9)
3. **Records the digits** by:
   - Displaying them in the console
   - Saving them to `digits.txt` file
4. **Provides statistics**:
   - Total count of digits found
   - List of unique digits

To run the app, compile and execute it with:
```bash
csc txtreader.cs
./txtreader
```

The app will output the digits to both the console and save them to a `digits.txt` file for persistent storage.

Made changes.*/