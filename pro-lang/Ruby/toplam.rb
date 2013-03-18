
def sum(sayi)
  toplam = 0
  for num in 1..sayi
    toplam += num
  end
  toplam
end

puts "toplam = #{sum(10)}"

