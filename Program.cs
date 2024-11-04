// See https://aka.ms/new-console-template for more information
while (true)
{
    Console.WriteLine("This is a new Object.\n");
    var NewObject = new EtatHistorique();
    bool inObject = true;
    while (inObject)
    {
        try
        {
            Console.WriteLine("To view history, type 'history'. To change state, type 'change'." +
                "To create a new object, type 'create'.\n");
            string client_input = Console.ReadLine();
            if (client_input == "history")
            {
                Console.WriteLine("Object history thus far.\n");
                NewObject.ShowHistory();
            }
            else if (client_input == "change")
            {
                Console.WriteLine("Write a description about the change.");
                string change_description = Console.ReadLine();
                NewObject.ChangeState(change_description);
                Console.WriteLine("Changes saved!\n");
            }
            else if (client_input == "create")
            {
                inObject = false;
            }
            else
            {
                throw new Exception("Oops");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Didn't understand your choice.\n");
        }

    }
}

