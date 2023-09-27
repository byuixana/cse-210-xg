using System.ComponentModel;

public class Resume {
    private string _applicantName;
    private string _companyName;
    
    private int _experienceLevel;

    public Resume(string name, string company, int experience){
        _applicantName = name;
        _companyName = company;
        _experienceLevel = experience;
    }

    public void DisplayData(){
        Console.WriteLine($"Name: {_applicantName} Company: {_companyName} Experience: {_experienceLevel}.");
    }



    }