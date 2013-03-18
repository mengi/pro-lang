# -*- coding: cp1254 -*-

class UniYer:
    def __init__(self,ad,soyad):
        self.ad=ad
        self.soyad=soyad
    def isim_cagir(self):
        print "hoşgeldiniz sayın",self.ad,self.soyad
    def tc_no(self):
        while True:
            a=input("\ntc kimlik numaranızı giriniz:")
            if len(str(a))==11:
                print str(a)
                break;
            else :
                print "tc kimlik no 11 haneli olmalıdır.tekrar deneyiniz."


class OgretimUye(UniYer):
    def __init__(self,ad,soyad):
        UniYer.__init__(self,ad,soyad)

    def santral(self):
        a=input("size ulaşmamız için santral numaranızı giriniz : ")
        print a


class Ogrenci(UniYer):
    def __init__(self,ad,soyad):
        UniYer.__init__(self,ad,soyad)
    def kimlik(self):
        while (1):
            a=input("öğrenci numaranızı giriniz : ")
            if len(str(a))==8:
                print a
                break
            else:
                print "\nöğrenci numarası 8 haneden oluşur.tekrar deneyiniz"

class Burslu(Ogrenci):
    def __init__(self,ad,soyad):
        Ogrenci.__init__(self,ad,soyad)

    def burs(self):
        a=raw_input("burslu musunuz (e/h) : ")
        if str(a)=="e":
            print "harç paranız 170 tl"
        else:
            print "harç paranız 420 tl "
                
#budaki fonksiyonlar deneme amaçlı olarak karışık çağırılmıştır.
#kendiniz düzenleyebilirsiniz.
    
        
   
f1=UniYer("buraya isim gir","buraya soyadını gir")
f2=OgretimUye("buraya isim gir","buraya soyadını gir")
f3=Ogrenci("buraya isim gir","buraya soyadını gir")
f4=Burslu ("buraya isim gir","buraya soyadını gir")
f2.isim_cagir()
f3.kimlik()
f4.tc_no()
f4.burs()
