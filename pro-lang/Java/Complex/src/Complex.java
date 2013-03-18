
public class Complex {
	public double imajener, reel;
	
	public Complex(double i, double r){
		this.imajener = i;
		this.reel = r;
	}
	public double GosterÝmajer(){
		return this.imajener;
	}
	public double Gosterreel(){
		return this.reel;
	}
	public String Goster(){
		return GosterÝmajer() + "i" + " + " + Gosterreel(); 
	}
	public Complex Topla(Complex other){
		return new Complex(this.imajener + other.imajener, this.reel + other.reel);
	}
	public Complex Cikar(Complex other){
		return new Complex(this.imajener - other.imajener, this.reel - other.reel);
	}
	public double Mutlak(){
		return Math.pow(imajener, 2) + Math.pow(imajener, 2);
	}
	public Complex Carpma(Complex other){
		double s1, s2;
		s1 = this.reel * other.reel + (-1 * this.imajener * other.imajener);
		s2 = this.imajener * other.reel + other.imajener * this.reel;
		return new Complex(s2, s1);
	}public Complex bolme(Complex other){
		double s1, s2, s3;
		s1 = this.reel * other.reel + (-1 * this.imajener * -1 * other.imajener);
		s2 = this.imajener * other.reel + other.imajener * this.reel;
		s3 = Math.pow(other.reel, 2) + (-1 * Math.pow(other.imajener, 2));
		return new Complex(s2 /s3, s1 / s3);
	}
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Complex nesne = new Complex(5.22, 7.9);
		Complex nesne1 = new Complex(4.1, -3.0);
		Complex sonuc = nesne.Topla(nesne1);
		Complex sonuc1 = nesne.Cikar(nesne1);
		Complex sonuc2 = nesne.Carpma(nesne1);
		Complex sonuc3 = nesne.bolme(nesne1);
		System.out.println("1.complex sayinin sanal veya imajener kismi " + nesne.GosterÝmajer());
		System.out.println("1.complex sayinin ree kismi " + nesne.Gosterreel());
		System.out.println("Toplama Sonuc : " + sonuc.Goster());
		System.out.println("Cýkarma sonuc : " + sonuc1.Goster());
		System.out.println("Carpma sonuc : " + sonuc2.Goster());
		System.out.println("Bolme Sonuc : " + sonuc3.Goster());
		System.out.println("complex sayinin mutlagý : " + nesne.Mutlak());
		System.out.println("1.complex sayi : " + nesne.Goster());
		System.out.println("2.complex sayini : " + nesne1.Goster());

	}

}
