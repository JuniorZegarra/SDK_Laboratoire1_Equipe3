using LibrairieConversionNote;

while (true)
{

    Console.Write("Type de conversion à faire : ");
    var input = Console.ReadLine();

    //Si l'utilisateur tape note
    if (input?.ToUpperInvariant() == "NOTE")
    {
        //On demande en boucle la conversion 
        while (true)
        {
            Console.Write("Conversion à faire : ");
            var note = Console.ReadLine();
            ConversionAlphabetiqueToNote conversion = new ConversionAlphabetiqueToNote();
            string noteRetour = conversion.Convert(note); //APPEL DE VOTRE LIB
            Console.Write(noteRetour);
            Console.WriteLine();
        }
    }
}