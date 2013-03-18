import java.util.ArrayList;
// import java.util.Arrays;
import javax.swing.JOptionPane;


public class Kay�tlistesi {
	ArrayList<String> liste = new ArrayList<String>(); 
	private void menu_ekrani(){
		String str = "L�tfen seciminizi yap�n�z:\n  ************************";
		str += "\n[1] Listeye yeni isim giriniz:";
		str += "\n[2] Listeden isim sil";
		str += "\n[3] Listeyi G�ster";
		str += "\n[0 ve cancel] C�kmak icin birini giriniz:";
		
		String Secimgir = this.girisal(str);
		if(Secimgir == null){
			Secimgir = "0";
		}else if(Secimgir.equals(" ") || Secimgir.matches("[^0-9]+")){
			this.menu_ekrani();
		}
		int no = Integer.parseInt(Secimgir);
		switch(no){
		case 0:this.c�k�s();break;
		case 1:this.Kisi_ekle();break;
		case 3:this.liste_goster();break;
		default:JOptionPane.showMessageDialog(null, "yanli� giri�");
		this.menu_ekrani();
		}
		
	}
	private void Kisi_ekle(){
		String ekle = this.girisal("L�tfen ismini giriniz :");
		if(ekle != null){
			if(liste.indexOf(ekle) == -1){
				liste.add(ekle);
				JOptionPane.showMessageDialog(null, "kayit oldu");
			}else{
				JOptionPane.showInputDialog("kay�t daha onceden vard�r");
			}
			this.menu_ekrani();
		}
	}
	private void c�k�s(){
		String rakam = JOptionPane.showInputDialog("c�k�s");
		if(Integer.parseInt(rakam) == 0 || rakam == null){
			System.exit(0);
		}else{
			this.menu_ekrani();
		}
			
	}
	public void liste_goster(){
		String str;
		str = "�sim listesi\n*****************\n";
		
		for(int i = 0; i < liste.size(); i++){
			str+="["+i+"]" + liste.get(i) + "\n";
		}
		str += "toplam =>" + liste.size();
		JOptionPane.showMessageDialog(null, str);
		this.menu_ekrani();
		
	}
	
	public String girisal(String str){
		return JOptionPane.showInputDialog(str);
	}
	public void Uygulama_baslat(){
		this.menu_ekrani();
	}
	
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Kay�tlistesi a = new Kay�tlistesi();
		a.Uygulama_baslat();
		a.liste_goster();

	}

}
