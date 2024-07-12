string[] lines = File.ReadAllLines("Partecipanti.txt");
Random rnd = new Random();
string scelto = lines[rnd.Next(lines.Length)];
if (File.Exists("Scelti.txt") && File.ReadAllLines("Scelti.txt").Contains(scelto))
    Console.WriteLine(scelto + " è già presente nella lista.");    
else
    File.AppendAllText("Scelti.txt", $"{scelto}\n");