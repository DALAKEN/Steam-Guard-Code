using SteamAuth;

static class SteamTOTP
{
	public static string GenerateSteamCode(string sharedSecret)
	{
		SteamGuardAccount account = new SteamGuardAccount();
		account.SharedSecret = sharedSecret;
		return account.GenerateSteamGuardCode();
	}
}

class Program
{
	public static void Main()
	{
		string sharedSecret = "3Ov0jBh9L0EMlP4fLu0tvtFIt9g=";

		while (true)
		{
			Console.Clear();
			Console.WriteLine($"Steam Guard: {SteamTOTP.GenerateSteamCode(sharedSecret)}");
			System.Threading.Thread.Sleep(1000);
		}
	}
}