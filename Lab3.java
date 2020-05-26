
public class Lab3 {

	public static void main(String[] args) {
		int programSize = 100;
		Memory HDD = new Memory(1000, false);
		Memory RAM = new Memory(50, true);

		MemoryManager memoryManager = new MemoryManager(HDD, RAM, programSize);

		memoryManager.invoke(20);
	}

}
