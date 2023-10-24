//WHILE LOOPS
Console.WriteLine("Enter a Number between (1-20): ");
int number = int.Parse(Console.ReadLine());

// Starting sequence value
number = number + 1;

// The end of the sequence
int target = number + 5;

Console.WriteLine("The next 5 numbers are: ");

// Loop runs until the number becomes equal to target
while(number < target){
  // Finding the next number in sequence
  Console.WriteLine(number);
  number = number + 1;
}


//______________________________________
//DO-WHILE LOOPS
int number;
bool valid = true;
Console.WriteLine("Enter A Number between 1-100: ");
do {
  // variable to store input string
  string? userInput = Console.ReadLine();

  // checking if the input string can be parsed
  valid = int.TryParse(userInput, out number);

  // checking if the input value is within the range
  if (number < 1 || number > 100) {
    valid = false;
  }

  // if input is not valid, a new prompt for getting data
  if (!valid) {
    Console.WriteLine("Enter a Valid Input: ");
  }

} while (!valid);


//______________________________________
//FOR LOOPS
Console.WriteLine("Enter a Number between (1-20): ");
int number = int.Parse(Console.ReadLine());

// The end of the sequence
int target = number + 5;

Console.WriteLine("The next 5 numbers are: ");

// Loops run until counter becomes equal to target
for (int i = number + 1; i <= target; i++) {
  Console.WriteLine(i);
}


//______________________________________
//INFINITE LOOPS
void displayChoices(){
    Console.WriteLine("MENU");
    Console.WriteLine("----");
    Console.WriteLine("1. Double Input");
    Console.WriteLine("2. Quadruple Input");
    Console.WriteLine("3. Exit");
}

bool continueProgram = true;
int number;

while (continueProgram) {
    displayChoices();
    Console.WriteLine("Enter Your Choice: ");

    int choice = int.Parse(Console.ReadLine());
    switch (choice) {
        case 1:
            Console.WriteLine("Enter Input Number: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Double: " + 2 * number);
            break;
        case 2:
            Console.WriteLine("Enter Input Number: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Quadruple: " + 4 * number);
            break;
        default:
            Console.WriteLine("Quitting....");
            continueProgram = false;
            break;
    }
}


//______________________________________
//NESTED LOOPS
for (int i = 0; i < 4; i++) {
    for (int j = 0; j < 4; j++) {
        Console.Write("0 ");
    }
    Console.WriteLine();
}

static int readValidInput() {
    int number = 0;
    bool valid = false;
    Console.WriteLine("Enter a number: ");

    while (!valid) {
        valid = int.TryParse(Console.ReadLine(), out number);
        if (!valid) {
            Console.WriteLine("Enter a valid number: ");
        }
    }

    return number;
}

int num1 = readValidInput();
int num2 = readValidInput();
Console.WriteLine();

for (int i = 1; i <= num1; i++) {
    for (int j = 1; j <= num2; j++) {
        Console.Write("* ");
    }
    Console.WriteLine();
}

int num1 = readValidInput();
Console.WriteLine();

for (int i = 1; i <= num1; i++) {
    for (int j = 1; j <= i; j++) {
        Console.Write("*");
    }
    Console.WriteLine();
}


