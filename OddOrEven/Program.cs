

Console.WriteLine("Enter a number:");
int userNum = Convert.ToInt32(Console.ReadLine());

//kas kasutaja arv on paaris või paaritu

int result = userNum % 2;

if(result !=0)
{
    Console.WriteLine("User number is ood.");
}
else
{
    Console.WriteLine("User number is even.");
}
