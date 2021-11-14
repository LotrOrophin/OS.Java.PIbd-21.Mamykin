import java.util.concurrent.atomic.AtomicBoolean;
import java.util.concurrent.atomic.AtomicInteger;

public class Process {
    public boolean[] flag;
    public int[] label;
    public static int n;

    public Process(int n) {
        this.n = n;
        flag = new boolean[n];
        label = new int[n];
        for (int i = 0; i < n; i++) {
            flag[i] = new boolean();
            label[i] = new int();
        }
    }

    public void lock() {
        int i = ThreadHelper.get();
        flag[i] = true;
        label[i] = findMax(label) + 1;
    }

    private int findMax(int[] a) {
        int max = 0;
        for (int e : a) {
            if (e > max) {
                max = e;
            }
        }
        return max;
    }
}