public class Memory {
	private int size;
	private Page[] pages;

	public Memory(int size, boolean isClear) {
		this.size = size;

		int pagesCount = size / 10 + 1;
		pages = new Page[pagesCount];
		for (int i = 0; i < pagesCount; i++) {
			int pageNumber = isClear? -1 : i;
			pages[i] = new Page(pageNumber);
		}
	}

	public Page getPage(int ingex) {
		return pages[ingex];
	}

	public void setPage(Page page, int index) {
		pages[index] = page;
	}

	public String getPagesList() {
		String answer = "";

		for (int i = 0; i < pages.length; i++) {
			answer += i;
			answer += " : ";
			answer += pages[i].getNumber();
			answer += "\n";
		}

		return answer;
	}

	public int getSize() {
		return size;
	}
}
