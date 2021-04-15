package practicas.practicasjava.practica3.informacionweb;
import java.awt.Color;
import java.net.*;
import java.net.InetAddress;
import java.net.UnknownHostException;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.awt.BorderLayout;
import java.awt.FlowLayout;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;
import javax.swing.ScrollPaneConstants;
import javax.swing.plaf.DimensionUIResource;
import java.io.*;
import java.awt.event.*;
import java.io.BufferedReader;
public class Consultador extends JFrame implements ActionListener{
    /**
     *
     */
    JPanel panelinferior,panelcentral,panelsup;
    JButton btn_aceptar,btn_limpiar;
    JTextArea area_txt;
    JLabel lbl_titulo;
    String texto="";
    String url;
    JScrollPane scroll;
    public Consultador(){
        initComponents();
    }
    public void initComponents(){
        this.setSize(600,300);
        this.setVisible(true);
        this.setBackground(Color.LIGHT_GRAY);
        this.setLayout(new BorderLayout(5,5));
        this.setDefaultCloseOperation(EXIT_ON_CLOSE);
        this.setLocationRelativeTo(null);
        panelcentral=new JPanel();
        area_txt=new JTextArea();
        area_txt.setEditable(false);
        area_txt.setPreferredSize(new DimensionUIResource(570,500));
        scroll=new JScrollPane(area_txt);
        scroll.setVerticalScrollBarPolicy(ScrollPaneConstants.VERTICAL_SCROLLBAR_ALWAYS);;
        scroll.setPreferredSize(new DimensionUIResource(575,200));
        panelcentral.add(scroll);
        this.add(panelcentral,BorderLayout.CENTER);
        panelinferior=new JPanel();
        panelinferior.setLayout(new FlowLayout());
        btn_aceptar=new JButton("Aceptar");
        btn_aceptar.addActionListener(this);
        btn_limpiar=new JButton("Limpiar");
        btn_limpiar.addActionListener(this);
        panelinferior.add(btn_aceptar);
        panelinferior.add(btn_limpiar);
        panelinferior.setBackground(Color.PINK);
        this.add(panelinferior,BorderLayout.SOUTH);
        panelsup=new JPanel();
        panelsup.setBackground(Color.PINK);
        lbl_titulo=new JLabel();
        lbl_titulo.setText("Consultor de pagina Web");
        panelsup.add(lbl_titulo);
        this.add(panelsup,BorderLayout.NORTH);

    }

    private static final long serialVersionUID = 1L;
    static private final Logger LOGGER = Logger.getLogger("www.itescam.edu.mx");

    public void obtenerIP() throws UnknownHostException {
        url=JOptionPane.showInputDialog(null,"Indique la pagine web");
        texto+=url+"\n";
        InetAddress ip = InetAddress.getByName(url);
        texto+="La IP es: "+ip.getHostAddress();
        refresh();
        documentoPrincipal(url);
        tiempoCarga(url);
    }    
    public void documentoPrincipal(String host) {
        try {
            Socket socket = new Socket(host, 80);
            InputStream input = socket.getInputStream();
            texto+="\n"+input;
            refresh();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
    public void tiempoCarga(String host){
        try {
            Socket socket = new Socket(host, 80);
            double time = socket.getSoTimeout();
            texto+="\nEl tiempo de carga es de: "+time;
            refresh();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }    
    public void refresh(){
        area_txt.setText(texto);
    }
    @Override
    public void actionPerformed(ActionEvent e) {
        // TODO Auto-generated method stub
        if (e.getSource()==btn_aceptar) {
            try {
                obtenerIP();
            } catch (Exception er) {
                //TODO: handle exception
            }
        }
        if (e.getSource()==btn_limpiar) {
            area_txt.setText("");
            texto="";
        }
        
    }
}
