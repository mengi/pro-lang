def kaynak_kod():
    okunan = open('Lab09.kaynak_kod_kopyaLa.py','r')
    yazilan = open('kopyala.txt', 'w')
    while True:
        foo = okunan.read(50)
        if metin == " ":
            break
        yazilan.write(foo) 
    okunan.close()
    yazilan.close()
    return
