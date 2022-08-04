var form = new GralForm(1, 4, 3);

if( form.Determinant() ){
    System.Console.WriteLine($@"x1 = {form.GetX1()}, 
x2 = {form.GetX2()}");

} else {
    Console.WriteLine("No hay soluciones reales");
}

class GralForm {

    int a, b, c;
    float x1, x2;
    double det;

    public GralForm(int a, int b, int c){
        this.a = a;
        this.b = b;
        this.c = c;
        this.Solution();   
        this.det = (Math.Pow(b, 2) - 4 * a * c);
    }

    private void Solution(){
        x1 = (float) (-b + Math.Sqrt((Math.Pow(b, 2) - 4 * a * c)) ) / (2*a);
        x2 = (float) (-b - Math.Sqrt((Math.Pow(b, 2) - 4 * a * c)) ) / (2*a);
    }

    public bool Determinant(){
        if ( det >= 0 ){
            return true;
        } else {
            return false;
        }
    }

    public float GetX1(){
        return x1;
    }

    public float GetX2(){
        return x2;
    }

}



