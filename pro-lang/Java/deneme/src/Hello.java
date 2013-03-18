
public class Hello {
	int x, y, z;

	public Hello(int x, int y, int z) {
		this.x = x;
		this.y = y;
		this.z = z;

		System.out.println("Bir Üçgen Oluþturuldu.(x: " + x + ", y: " + y + ", z: " + z + ")");
	}

	public int cevre() {
		return x + y + z;
	}
	
	 public static void main(String[] args){
		 
		 System.out.println("gir : " + cevre(8,5,6) );
	 }

}
