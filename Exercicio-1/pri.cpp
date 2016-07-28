#include "pri.h"

pri::pri()
{
    menores = "";
}
void pri::preencherMatriz(){
    for(int i = 0 ; i < 4 ; i++){
        cout<<"Qual tamanho da  "<<i+1<<"º matriz \n";
        cin>>tam;

        cout<<"Forneca-a \n";

        for(int j =0; j<4 ; j++){
            if(j >= tam){
                matrizes[i][j] = 0;
            }else{
                cin>>matrizes[i][j];
            }
       }
        system("cls");
    }
}

string pri::proMenor(){
    int menor;
    for(int i =0 ; i< 4; i++){
        menor = matrizes[i][0];
        for(int j =1;j<4 && matrizes[i][j] != 0 ;j++){
            if(matrizes[i][j] < menor){
                menor = matrizes[i][j];
            }
        }
        menores +=std::to_string(menor);
    }
    return menores;
}
