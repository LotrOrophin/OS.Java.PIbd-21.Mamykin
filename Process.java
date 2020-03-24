
import java.util.ArrayList;

public class Process {
	private Timer timer;
	
	private String name;
	private int priority;
	private ArrayList<Thread> threads;
	
	public Process(String name, int priority, Timer timer) {
		this.timer = timer;
		
		this.name = name;
		this.priority = priority;
		
		threads = new ArrayList<Thread>();
		int threadsCount = (int) (Math.random() * 5 + 1);
		for (int i = 0; i < threadsCount; i++) {
			int p = (int) (Math.random() * 5 + 1);
			threads.add(new Thread("" + i, p, timer));
		}
	}
	
	public boolean invoke(int allottedTime) {
		log("  На выполнении процесс " + name + " с приоритетом " + priority);
		
		int sumPiority = 0;
		for (int i = 0; i < threads.size(); i++) {
			sumPiority += threads.get(i).getPriority();
		}
		
		int allottedTimeForThread = allottedTime / sumPiority;
		
		for (int i = 0; i < threads.size(); i++) {
			boolean isThreadClosed = threads.get(i).invoke(
									allottedTimeForThread * threads.get(i).getPriority());
			
			if (isThreadClosed) {
				threads.remove(i);
				i--;
			}
		}
		
		if (threads.isEmpty()) {
			log("  Потоков не осталось");
			return true;
		} else {
			return false;
		}
	}
	
	private void log(String message) {
		System.out.println(timer.getTime() + "  :" + message);
	}
	
	public int getPriority() {
		return priority;
	}
}
