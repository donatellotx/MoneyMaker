namespace MoneyMaker
    {
        class MainClass
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Money Maker!");

                Console.WriteLine("Enter an amount to calculate number of coins used");
                string userInputAmount = Console.ReadLine();
                double inputAmount = Convert.ToDouble(userInputAmount);
                Console.WriteLine($"{inputAmount} cents is equal to...");

                double goldValue = 10;
                double silverValue = 5;

                double goldCoins = Math.Floor(inputAmount / goldValue);
                double remainder = (inputAmount % goldValue);

                double silverCoins = Math.Floor(remainder / silverValue);
                remainder = remainder % silverValue;

                Console.WriteLine($" Gold coins: {goldCoins} \n Silver coins: {silverCoins} \n Bronze coins: {remainder}");


            }
        }

}
    
