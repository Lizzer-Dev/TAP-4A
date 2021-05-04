package ejerciciochat;
import java.awt.BorderLayout;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;
import javax.swing.ScrollPaneConstants;
import java.awt.event.*;
import java.io.IOException;
import java.net.ServerSocket;
public class Servidor extends JFrame implements ActionListener {
    JButton btn_reiniciar,btn_salir;
    JPanel panelce,panelinf,panelsup;
    JLabel lbl_titulo,lbl_options,lbl_center;
    JTextArea area;
    ServerSocket server;
    String texto;
    JScrollPane scroll;
    public Servidor()throws IOException{
        super("Servidor");
        server=new ServerSocket(5000);
        initComponents();
    }
    public void start(){

    }
    public void initComponents(){
        start();
        this.setSize(300, 700);
        this.setLocationRelativeTo(null);
        this.setVisible(true);
        this.setDefaultCloseOperation(EXIT_ON_CLOSE);
        this.setLayout(new BorderLayout(5,5));
        //PANEL CENTRAL
        panelce=new JPanel();
        area=new JTextArea();
        area.setEditable(false);
        scroll=new JScrollPane(area);
        scroll.setVerticalScrollBarPolicy(ScrollPaneConstants.VERTICAL_SCROLLBAR_ALWAYS);
        panelce.add(scroll);
        panelsup=new JPanel();
        panelinf=new JPanel();

    }
    @Override
    public void actionPerformed(ActionEvent e) {
        // TODO Auto-generated method stub
        
    }
    public static void main(String[] args) {
        Servidor serv=new Servidor();
    }
}
