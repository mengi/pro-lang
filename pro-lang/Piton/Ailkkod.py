x = raw_input("kullanici adiniz:")
y = raw_input("sifrenizi giriniz:")

while True:
	if not(4 <= len(y) and len(y) <= 10):
		print len(y)
		print "sifrenizin uzunlugu 4 ile 10 arasinda olmalidir"
		y = raw_input("sifrenizi giriniz:")
	else:
		break 

a = "123456789" #kullanici bu karakterlerden herhangi birini girdigi zaman puan degiskeni 2 artar..
b = "abcdefghijklmnoprstuvyz"  #kullanici bu karakterlerden herhangi birini girdigi zaman puan degiskeni 1 artar..
c = "ABCDEFGHIJKLMNOPRSTUVYZ" #kullanici bu karakterlerden herhangi birini girdigi zaman puan degiskeni 2 artar..
d = "!'^+%&/()=?<>#${[]}\|-*"  #kullanici bu karakterlerden herhangi birini girdigi zaman puan degiskeni 3 artar..
e = "_"  #kullanici bu karakterlerden herhangi birini girdigi zaman puan degiskeni 4 artar..

puan = 0

for i in y:
	
	if i in a:
		puan = puan + 2 
		
	if i in b:
		puan = puan + 1 
		
	if i in c:
		puan = puan + 2 
		
	if i in d:
		puan = puan + 3 
		
	if i in e:
		puan = puan + 4 	
			
if puan < 12:
	print "sifreniz zayif:",puan
if puan > 12 and puan < 20:
	print "sifreniz orta:",puan
if puan > 20 and puan < 30:
	print "sifreniz guclu:",puan
if puan > 30 and puan < 40:
	print "sifreniz cok guclu:",puan

if puan < 12:
	import turtle
	t = turtle
	t.color("green")
	t.pensize(30)
	t.forward(20)
	t.up()
	t.forward(40)
	t.write("zayif")
	import time 
	time.sleep(3)
	
if puan >= 12 and puan < 20:
	import turtle
	t = turtle
	t.color("light blue")
	t.pensize(30)
	t.forward(80)
	t.up()
	t.forward(40)
	t.write("orta")
	import time 
	time.sleep(3)

if puan >= 20 and puan < 30:
	import turtle
	t = turtle
	t.color("blue")
	t.pensize(30)
	t.forward(120)
	t.up()
	t.forward(40)
	t.write("guclu")
	import time 
	time.sleep(3)

if puan >= 30 and puan <= 40:
	import turtle
	t = turtle
	t.color("red")
	t.pensize(30)
	t.forward(160)
	t.up()
	t.forward(40)
	t.write("cok guclu")
	import time 
	time.sleep(3)

	
	
	
	
