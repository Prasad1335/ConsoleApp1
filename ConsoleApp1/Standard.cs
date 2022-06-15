// See https://aka.ms/new-console-template for more information
public class Standard
{
    public int StandardID;
    public string StandardName;

    IList<Standard> standardList = new List<Standard>() {
new Standard(){ StandardID = 1, StandardName="Standard 1"},
new Standard(){ StandardID = 2, StandardName="Standard 2"},
new Standard(){ StandardID = 3, StandardName="Standard 3"}
};
}


// display Age is gratter 18 Write query expression & query Method
// display Age is gratter 12 and less 20 Write query expression & query Method
// to display list students group by StandardID Write query expression & query Method

