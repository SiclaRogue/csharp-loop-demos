Console.WriteLine("Hello World, this will show some basic loop logic");
Console.ReadKey();

Console.WriteLine("\'for\' loop:");
//Starting state, condition, modifier 
//note that for loops will check the condition before entering the loop
for (int i = 1; i <= 5; i++)
{
    if (i == 1)
    {
        Console.WriteLine("This loop has been iterated " + i + " time.");
    }
    else
    {
        Console.WriteLine("This loop has been iterated " + i + " times.");
    }
}

Console.ReadLine();

Console.WriteLine("\'for\' loops can also iterate over collections using \'for each\'");

Console.ReadLine();

string[] words = { "first", "second", "third", "forth", "fifth" };
//element in list of elements, will work on anything that properly interfaces Collections
foreach (var word in words)
{
    Console.WriteLine(word);
    Console.ReadKey();
}

Console.WriteLine("You can also nest loops within loops.");

foreach (var word in words)
{
    Console.WriteLine(word + " outer loop");
    for (int i = 1; i <= 3; i++)
    {
        if (i == 1)
        {
            Console.WriteLine("This inner loop has been iterated " + i + " time.");
        }
        else
        {
            Console.WriteLine("This inner loop has been iterated " + i + " times.");
        }
    }
    Console.ReadKey();
}

Console.ReadLine();
//for loops are best for when you know how many times you will run a loop once you reach the loop in runtime.
//while is best for when you don't know how many times you'll run a loop.
Console.WriteLine("Also exists are \'while\' loops and \'do while\' loops they are effectively " +
    "the same exepct for one simple but important behavior");

Console.ReadKey();

int j = 1;
//while loops check the condition before entering the loop, same as for loops.
while (j <= 5)
{
    if (j == 1)
    {
        Console.WriteLine("This loop has been iterated " + j + " time.");
    }
    else
    {
        Console.WriteLine("This loop has been iterated " + j + " times.");
    }
    //unlike for loops your iterator or change in condition must happen inside the loop block
    //risk of infinate loops
    j++;
}
Console.ReadLine();

//do while loops check the condition After executeing the code in the loop, so it will always run the code once
int k = 6;
do
{
    Console.WriteLine("Variable k is " + k);
    k--;
    Console.ReadKey();

} while (k <= 5 && k > 0);

Console.ReadLine();

Console.WriteLine("Two more simple actions involveing \'loops is break;\' and \'continue;\' ");
Console.ReadKey();
Console.WriteLine("\'break;\' will fully break out of the current loop reguardless of the current condition");
Console.ReadLine();

for (int i = 1; i <= 10; i++)
{
    if (i == 1)
    {
        Console.WriteLine("This loop has been iterated " + i + " time.");
    }
    else
    {
        Console.WriteLine("This loop has been iterated " + i + " times.");
    }
    if (i == 8)
    {
        Console.ReadKey();
        break;
    }
}

Console.ReadLine();
Console.WriteLine("\'continue;\' will skip the remaining lines of code in a loop block but will re-check the condition of the loop and run it");
Console.ReadLine();

for (int i = 1; i <= 10; i++)
{
    //the write out for 8 will be skipped but the loop will continue
    if (i == 8)
    {
        Console.ReadKey();
        continue;
    }
    if (i == 1)
    {
        Console.WriteLine("This loop has been iterated " + i + " time.");
    }
    else
    {
        Console.WriteLine("This loop has been iterated " + i + " times.");
    }
}

Console.ReadKey();