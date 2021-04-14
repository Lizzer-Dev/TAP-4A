package proyecto;
import java.awt.*;
import javax.swing.plaf.DimensionUIResource;
import javax.swing.Icon;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import java.awt.event.*;
//import javazoom.jlgui.basicplayer.BasicPlayer;
import java.io.File;
public class Reproductor extends JFrame implements ActionListener{

    /**
     *
     */
    private static final long serialVersionUID = 1L;
    JPanel panelderecho,panelizquierdo,panelcentral,panelsuperior,panelinferior;
    JPanel panelsubcentral,panelsubcentralsup;
    JButton btn_play,btn_siguiente,btn_anterior,btn_abrir;
    JLabel lbl_titulo,lbl_leder,lbl_leiz,lbl_lesup;
    Image portada;
    //BasicPlayer player;
    public Reproductor(){
        super("Reproductor de audio");
        initComponents();
    }

    public void initComponents(){
        this.setSize(1050,700);
        this.setVisible(true);
        this.setDefaultCloseOperation(EXIT_ON_CLOSE);
        this.setLocationRelativeTo(null);
        this.setBackground(Color.WHITE);
        this.setLayout(new BorderLayout(5,5));
        //PANEL CENTRAL
        panelCentral();
        panelIzquierdo();
        panelSuperior();
        panelDerecho();
        
        

    }

    public void panelIzquierdo(){
        panelizquierdo= new JPanel();
        panelizquierdo.setLayout(new FlowLayout());
        panelizquierdo.setBackground(Color.DARK_GRAY);
        panelizquierdo.setPreferredSize(new DimensionUIResource(250,700));
        btn_abrir=new JButton("Abrir archivo");
        btn_abrir.addActionListener(this);
        panelizquierdo.add(btn_abrir);
        this.add(panelizquierdo,BorderLayout.WEST);
    }

    public void panelDerecho(){
        panelderecho=new JPanel();
        panelderecho.setLayout(new GridLayout(2,5));
        panelderecho.setBackground(Color.ORANGE);
        panelderecho.setPreferredSize(new DimensionUIResource(250,700));
        this.add(panelderecho,BorderLayout.EAST);
    }

    public void panelSuperior(){
        panelsuperior=new JPanel();
        panelsuperior.setLayout(new FlowLayout());
        panelsuperior.setBackground(Color.BLACK);
        panelsuperior.setPreferredSize(new DimensionUIResource(100,100));
        this.add(panelsuperior,BorderLayout.NORTH);
    }

    public void panelCentral(){
        panelcentral=new JPanel();
        panelcentral.setLayout(new BorderLayout());
        panelcentral.setBackground(Color.DARK_GRAY);
        portada=Toolkit.getDefaultToolkit().getImage("recursos/portada.jpg");
        btn_play=new JButton("Play");
        btn_play.setBackground(Color.DARK_GRAY);
        btn_play.addActionListener(this);
        btn_anterior=new JButton("Anterior");
        btn_anterior.addActionListener(this);
        btn_siguiente=new JButton("Siguiente");
        btn_siguiente.addActionListener(this);
        panelsubcentral=new JPanel();
        panelsubcentral.setLayout(new FlowLayout());
        panelsubcentral.setBackground(Color.BLUE);
        panelsubcentral.add(btn_anterior);
        panelsubcentral.add(btn_play);
        panelsubcentral.add(btn_siguiente);
        panelcentral.add(panelsubcentral,BorderLayout.SOUTH);
        this.add(panelcentral,BorderLayout.CENTER);
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        // TODO Auto-generated method stub
        
    }
    public static void main(String[] args) {
        Reproductor repro=new Reproductor();
    }
}
