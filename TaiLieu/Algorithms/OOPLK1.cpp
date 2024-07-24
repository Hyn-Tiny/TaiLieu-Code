#include <iostream>
using namespace std;

//Compiler version g++ 6.3.0
class lienket
{
  private:
   struct Node{
  int Infor;
  Node *Link; 
};  
  public:
    void potsInsert(Node *F,Node *M, int x);
    int Delete(Node *F, Node *M);
    void Display(Node *F);
    int Find(Node *F, int x);
};

//

int main()
{
  lienket *F,*last;
   /* Node *F=NULL;
    Node *Last;
    int n, x;
    cout<<"nhap so";
    cin>>n;
    for(int i=0;i<n;i++)
    {
      printf("phan tu thu %d",i+1);
      cin>>x;
      if(F=NULL)
      {
        potsInsert(F,F,x);      
      }
      else
      {
        Last=F;
        while(Last->Link) Last =Last->Link;
        potsInsert(F,Last, x);
      }
    }
   cout<<"danh sach lien ket là" <<endl;
   Display(F);
   cout<<"nhap vao giá trị can xoa";
   cin>>x;
   Node *M=Find(F,x);
   if(M==NULL)
   {
     cout<<"\n ko tim thay";
   }
   else
   {
     cout<<"\n tim thay gia trị";
     cout<<"\nda tbuc hien xoa nut"<<Delete(F,M);
     Display(F);
   }*/
    cout << "Hello, Dcoder!";
    return 0;
}
void lienket::potsInsert(Node *F,Node *M, int x)
{
  Node *N=new Node;
  N->Infor=x;
  N->Link=NULL;
  if(F==NULL)
  {
    F=N;
  }
  else
  {
    N->Link=M->Link;
    M->Link=N;
  }
}
/*
void lienket::preInsert(Node *F,Node *M, int x)
{
  Node *N=new Node;
  N->Infor=x;
  N->Link=NULL;
  if(F==NULL)
  {
    F=N;
  }
  else
  {
    if(M==F)
    {
      N->Link=F;
      F=N;
    }
    else
    {
      Node *P=F;
      while(P->Link!=M) P=P->Link;
      
      P->Link=N;
      N->Link=M;
    }
  }
}

*/
int lienket::Delete(Node *F, Node *M)
{
  if(F==NULL)
  {
    cout<<"danh sach rong";
    return -1;
  }
  int tg=M->Infor;
  if(M==F)
  {
    F=F->Link;
  }
  else
  {
    Node *P=F;
    while(P->Link!=M) P=P->Link;
    P->Link=M->Link;
  }
  delete M;
  return 0;
}
void lienket::Display(Node *F)
{
  Node *P=F;
  while(P)
  {
    cout<<P->Infor<<" ";
    P=P->Link;
  }
} /*
 lienket::Node* Find(Node *F, int x)
{
  Node *P=F;
  while(P)
  {
    if(P->Infor==x)
    {
      return P;
    }
    else P=P->Link;
  }
  return NULL;
}*/