string[] hay = { "hsafsadf", "sdfsa" };
Console.WriteLine("gsfgsafgsfg");
IEnumerator bien = hay.GetEnumerator();
while (bien.MoveNext()) {
    string s = bien.Current.ToString();
    Console.WriteLine(s);

}
