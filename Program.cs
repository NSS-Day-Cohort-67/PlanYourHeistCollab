//Phase One

//Print "Plan Your Heist!"
Console.WriteLine("Plan Your Heist!");

//Create way to store single team member
//TeamMember: name(string), skillLevel(int), and courageFactor(decimal between 0.0 and 2.0) 
TeamMember newTeamMember = new TeamMember();

//Prompt user to enter team members name & save the name
Console.WriteLine("Enter team members name: ");
var newMemberName = Console.ReadLine();

//Prompt user for team members skillLevel & save the skillLevel
Console.WriteLine("Enter team members skillLevel(1-10): ");
int newMemberSkillLevel = int.Parse(Console.ReadLine());

//Prompt user to enter team members courageFactor & save the courageFactor
Console.WriteLine("Enter team members courage factor(0.0-2.0): ");
// decimal newMemberCourageFactor = decimal.Parse(Console.ReadLine());
bool resultCourageFactor = decimal.TryParse(Console.ReadLine(), out decimal newMemberCourageFactor);

//Build new Team Member Object
if(resultCourageFactor)
{
    newTeamMember.Name = newMemberName;
    newTeamMember.SkillLevel = newMemberSkillLevel;
    newTeamMember.CourageFactor = newMemberCourageFactor;
}
else
{
    Console.WriteLine("Invalid Input for Team Member Courage Factor.");
}

//Display the TeamMembers information
Console.WriteLine(@$"
    New Team Member:
    Name: {newTeamMember.Name},
    Skill Level: {newTeamMember.SkillLevel},
    Courage Factor: {newTeamMember.CourageFactor}
    ");
