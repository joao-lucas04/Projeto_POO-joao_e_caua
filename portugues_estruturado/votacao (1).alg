algoritmo "Votação"
// Função :Contabilizar os votos
// Autor :JL e Magalhães
// Data : 15/03/2023
// Seção de Declarações 
var
VJS,VM,VJO,VG,R:real
inicio
escreva("Votos do José da Silva: ")
leia(VJS)
escreva("Votos da Maria Jurema: ")
leia(VM)
escreva("Votos do João da Tapioca: ")
leia(VJO)
VG:=VJS+VM+VJO
se(VJS>VM) e (VJS>VJO)entao
R:=VJS/VG
Escreva("De ",VG ," votos no total, Maria Jurema foi o vencedor, com ",VM ," desse votos, correspondendo à ",R ," %dos Votos")
   senao
   se(VM>VJS) e (VM>VJO)entao
   R:=VM/VG
escreva("De ",VG ," votos no total, Maria Jurema foi o vencedor, com ",VM ," desse votos,correspondendo à ",R ," %dos Votos")
    senao
    R:=VJO/VG
escreva("De ",VG ," votos no total, João da Tapioca foi o vencedor, com ",VJO ," desse votos, correspondendo à ",R ," % dos Votos")
fimse
fimse
   
   
fimalgoritmo
