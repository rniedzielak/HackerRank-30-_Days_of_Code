        // Declare second integer, double, and String variables.
        int a;
        double b;
        string text;
        // Read and save an integer, double, and String to your variables.
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        text = Console.ReadLine();
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i+a);
        // Print the sum of the double variables on a new line.
        Console.WriteLine(string.Format("{0:F1}", d+b));
        // Concatenate and print the String variables on a new line
        Console.WriteLine(s+text);
        // The 's' variable above should be printed first.
