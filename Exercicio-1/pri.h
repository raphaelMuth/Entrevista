#ifndef PRI_H
#define PRI_H
#include <iostream>
using namespace std;


class pri
{
private:
    int tam;
    int matrizes[4][4];
    string menores;
public:
    pri();
    void preencherMatriz();
    string proMenor();
};

#endif // PRI_H
