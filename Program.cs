// See https://aka.ms/new-console-template for more information


using System;


void Main(){
Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

MooseSays("HEHEHEHEH XD");
MooseSays("I really am enthusiastic");

DoMooseResponse("Is Canada real?", "Really? It seems very unlikely.", "I K N E W I T !!!");
DoMooseResponse("Do birds exist?", "But they do not.", "I agree with you!");
DoMooseResponse("Does she really love you?", "I am happy for you!", "Sounds about right..."); 
}

Main();

void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

bool MooseAsks(string question){
    
Console.Write($"{question} (Y/N): ");
string answer = Console.ReadLine().ToLower(); 


while (answer != "y" && answer != "n"){   
Console.Write($"{question} (Y/N): ");
answer = Console.ReadLine().ToLower();
}

if (answer == "y") return true; 
else return false; 

}

void DoMooseResponse(string question, string yesAnswer, string noAnswer){
 bool isQuestionTrue = MooseAsks(question);

if (isQuestionTrue) MooseSays(yesAnswer);
else MooseSays(noAnswer);
}




