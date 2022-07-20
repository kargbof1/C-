var names = new List<string>();
            names.Add("Jon");
            names.Add("First");
            names.Add("Joe");
            names.Add("Jam");
            names.Add("middle");
            names.Add("Jerry");
            names.Add("Jill");
            names.Add("Last");
            names.Remove("Jon"); //Removes the Jon
            names.RemoveAt(0); //Removes the first name
            names.RemoveAt(names.Count-1); //Removes the last name
            names.RemoveAt(names.Count / 2); //Removes the middle name
            names.ForEach(Console.WriteLine); //Prints all names
            //Printing the index
            var index = names.IndexOf("Jerry");
            if (index != -1)
                Console.WriteLine($"The name {names[index]} is at index {index}");
