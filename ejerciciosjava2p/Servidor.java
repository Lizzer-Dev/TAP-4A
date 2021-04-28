package ejerciciosjava2p;
import java.io.IOException;
import java.net.ServerSocket;
public class Servidor{
    ServerSocket server;
    BufferedReader in;
    PrintWriter out;
    public ServerSocket() throws IOException{
        server=new ServerSocket(5000);
        Socket cc=server.accept();
        in=new BufferedReader(new InputStreamReader(cc.getInputStream()));
        out=new PrintWriter(cc.getOutputStream());
    }

    public void read()throws IOException{
        String line="";
        while(!line.equals("adios")){
            String line =in.readLine();
            switch (line) {
                case "hola":
                    out.println("Hola tambien");
                    out.flush();
                    break;
                case "adios":
                    out.println("Adios tambien");
                    out.flush();
                    break;
                case "cual es mi calificacion?":
                    out.println("0");
                    out.flush();
                    break;
                default:
                    break;
            }
            in.close();
            out.close();
        }
    }

    public static void main(String[] args) {
        try {
            Servidor s= new Servidor();
        } catch (Exception e) {
            //TODO: handle exception
            e.printStackTrace();
        }
    }
}

