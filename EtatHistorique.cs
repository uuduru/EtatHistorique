// See https://aka.ms/new-console-template for more information
using System.Text.Json.Nodes;

public class EtatHistorique
{
    private JsonArray _jsonArray;
    public EtatHistorique()
    {
        var jsonArray = new JsonArray();
        var change_info = new JsonObject();
        change_info["Date_of_transaction"] = DateTime.Now;
        change_info["Description_of_transaction"] = "Initial state.";
        jsonArray.Add(change_info);
        this._jsonArray = jsonArray;
    }

    public void ChangeState(string Description_of_change)
    {
        var change_info = new JsonObject();
        change_info["Date_of_transaction"] = DateTime.Now;
        change_info["Description_of_transaction"] = Description_of_change;
        _jsonArray.Add(change_info);
    }

    public void ShowHistory()
    {
        Console.WriteLine(_jsonArray);
    }

}

