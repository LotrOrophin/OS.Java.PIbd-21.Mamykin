
import java.util.ArrayList;

public class program {
	private Timer timer;
	
	private ArrayList<Process> processes;
	
	public program(Timer timer) {
		this.timer = timer;
		
		int processesCount = (int) (Math.random() * 4 + 3);
		processes = new ArrayList<Process>();
		for (int i = 0; i < processesCount; i++) {
			int p = (int) (Math.random() * 5);
			processes.add(new Process("" + i, p, timer));
		}
	}
	
	public void start() {
		
		while (!processes.isEmpty()) {
			int p = findMax();
			int i = 0;
			while(p >= 0) {
				
			
			while (i < processes.size()) {				
				if(processes.get(i).getPriority() == p) {
					int allottedTime = 500;
					
					boolean isProcessClosed = processes.get(i).invoke(allottedTime);
				
					if (isProcessClosed) {
						processes.remove(i);
						i--;
					}
				}
				i++;				
			}
			p--;
			}
		}
		
	}
	private int findMax() {
		int maxP = 0;
		for(int j = 0; j < processes.size(); j++) {
			if(processes.get(j).getPriority() > maxP)
				maxP = processes.get(j).getPriority();			
		}
		return maxP;
	}	
}
