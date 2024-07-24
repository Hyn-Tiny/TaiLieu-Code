#include <iostream>
#include <stdio.h>
using namespace std;

//Compiler version g++ 6.3.0

class stack
{
  private:
    struct Node
    {
      int Infor;
      Node *Link;
    };
    
  public:
    void Push(Node* &T,int x);
    int Pop(Node* &T);
    int Isempty(Node *T);
};

//int Top(Node *T);
//int Cout(Node *T);

int main()
{
  stack s;
 /* int n , thuong;
  cout<<"nhao so";
  cin>>n;thuong=n;
  while(thuong){
    Push(T,thuong%10);
    thuong/10;
    
  }
    cout<<"\nta co"<<n<<"co"<<Cout(T)<<"so";
    
    while(!Isempty(T))cout<<Pop(T)<<endl;
   */
      cout << "Hello, Dcoder!";
      return 0;
}

void stack::Push(Node* &T,int x)
{
  Node *N=new Node;
  N->Infor=x;
  N->Link=NULL;
  
  N->Link=T;
  T=N;
  
}
int stack::Pop(Node* &T)
{
  if(T==NULL)
  {
    cout<<"ngan xep rong";
    return -1;
  }
  int tg=T->Infor;
  Node *P=T;
  T=T->Link;
  delete P;
  return tg;
}
int stack::Isempty(Node *T)
{
  if(T==NULL)
  {
    return 1;
  }
  return 0;
}
/*int Top(Node *T)
{
  if(T==NULL)
  {
    cout<<"ngan xep rong";
    return -1;
  }
  return T->Infor;
}
int Cout(Node *T)
{
  int dem=0;
  Node *P=T;
  while(P)
  {
    dem++;
    P=P->Link;
  }
  return dem=0;
}*/