
[System.Serializable]
public class Resource
{
	public ResourceType Type { get; private set; }
	public int Amount { get; private set; }

	public Resource(ResourceType type, int amount)
	{
		Type = type;
		Amount = amount;
	}

	public void AddAmount(int amount)
	{
		Amount += amount;
	}

	public void SubtractAmount(int amount)
	{
		Amount -= amount;
	}
}