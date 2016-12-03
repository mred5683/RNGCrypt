using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO;

internal class Program {
  private static void Main() {

    //File.Create($"c:/users/Nash/desktop/ReadAndWriteToTextFile.txt").Close();

    StreamWriter writeFile = new StreamWriter($"c:/users/Nash/desktop/ReadAndWriteToTextFile.txt");

    Random random = new Random();

    for (int i = 0; i < 5; i++) {
      var x = random.Next(100000000, 999999999);
      writeFile.WriteLine(x);
    }
    writeFile.Close();

    //using (var rng = new RNGCryptoServiceProvider()) {
    //  // Buffer storage.
    //  var data = new byte[4];

    //  // Ten thousand iterations.
    //  for (var i = 0; i < 10; i++) {
    //    // Fill buffer.
    //    rng.GetBytes(data);

    //    // Convert to Uint 32.
    //    var value = BitConverter.ToUInt32(data, 0);
    //    writeFile.WriteLine(value);
    //  }
    //  writeFile.Close();
    //}

    StreamReader readFile = new StreamReader($"c:/users/Nash/desktop/ReadAndWriteToTextFile.txt");

    List<string> listOfAllLines = new List<string>();
    var currentLine = String.Empty;

    while ((currentLine = readFile.ReadLine()) != null) {
      listOfAllLines.Add(currentLine);
    }
    
    readFile.Close();
    Console.ReadKey();
    
  }
}