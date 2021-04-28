
public class Cliente{
    Socket socket;
    BufferedReader in;
    PrintWriter out;
    public Cliente() throws IOException,UknowHpstExeption{
        socket=new Socket("localhost",5000);
        in=new BufferedReader(new InputStreamReader(socket.getInputStream()));
        out=new PrintWriter(socket.getOutputStream());

    }
    public void write(){
       out.println("Hola");
       out.flush();
       String line=in.readLine();
       System.out.println(line);
       in.close();
       out.close();
    }
    public static void main(String[] args) {
        try {
            Cliente c=new Cliente();
            c.write();
        } catch (Exception e) {
            //TODO: handle exception
            e.printStackTrace();
        }
    }
}