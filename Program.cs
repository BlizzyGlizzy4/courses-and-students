var matematik = new Course("Matematik", 2);
var historia = new Course("Historia", 3);

var anna = new Student("Anna");
var björn = new Student("Björn");
var cissi = new Student("Cissi");

Console.WriteLine("Anmälan via kursens Enroll");
matematik.Enroll(anna);
matematik.Enroll(björn);

Console.WriteLine();
Console.WriteLine("Anmälan via studerandens Join");
cissi.Join(matematik); 
historia.Enroll(anna);
björn.Join(historia);
cissi.Join(historia);

Console.WriteLine();
Console.WriteLine("Dubbelanmälan ska inte ge dubbletter");
anna.Join(historia);
matematik.Enroll(anna);

Console.WriteLine();
Console.WriteLine("Status efter anmälningar");
Console.WriteLine(matematik);
Console.WriteLine(historia);
matematik.RollCall();
historia.RollCall();
anna.Schedule();
björn.Schedule();
cissi.Schedule();

Console.WriteLine();
Console.WriteLine("Avanmälan åt olika håll");
matematik.Remove(anna);      
björn.Leave(historia);      

Console.WriteLine();
Console.WriteLine("Ta bort en studerande som inte är anmäld ska inte krascha");
matematik.Remove(björn); 
cissi.Leave(matematik);  

Console.WriteLine();
Console.WriteLine("Status efter avanmälningar");
Console.WriteLine(matematik);
Console.WriteLine(historia);
matematik.RollCall();
historia.RollCall();
anna.Schedule();
björn.Schedule();
cissi.Schedule();