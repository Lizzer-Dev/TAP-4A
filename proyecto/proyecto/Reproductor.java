package proyecto;
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.Font;
import java.awt.GridLayout;
import java.awt.Image;
import java.awt.Toolkit;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.lang.System.Logger;

import javax.swing.JOptionPane;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFileChooser;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.plaf.DimensionUIResource;
import javazoom.jl.decoder.JavaLayerException;
import javazoom.jl.player.Player;
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
    String txtReproductor;
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
        this.setBackground(Color.BLACK);
        this.setLayout(new BorderLayout(10,10));
        //PANEL CENTRAL
        panelCentral();
        panelIzquierdo();
        panelSuperior();
        panelDerecho();
        panelInferior();
        
        

    }

    public void panelIzquierdo(){
        panelizquierdo= new JPanel();
        panelizquierdo.setLayout(new FlowLayout());
        panelizquierdo.setBackground(Color.LIGHT_GRAY);
        panelizquierdo.setPreferredSize(new DimensionUIResource(250,700));
        btn_abrir=new JButton("Abrir archivo");
        btn_abrir.addActionListener(this);
        panelizquierdo.add(btn_abrir);
        this.add(panelizquierdo,BorderLayout.WEST);
    }

    public void panelDerecho(){
        panelderecho=new JPanel();
        panelderecho.setLayout(new GridLayout(2,5));
        panelderecho.setBackground(Color.LIGHT_GRAY);
        panelderecho.setPreferredSize(new DimensionUIResource(250,700));
        this.add(panelderecho,BorderLayout.EAST);
    }

    public void panelSuperior(){
        panelsuperior=new JPanel();
        panelsuperior.setLayout(new FlowLayout());
        panelsuperior.setBackground(Color.BLACK);
        panelsuperior.setPreferredSize(new DimensionUIResource(100,100));
        Font fuente= new Font("",3,25);
        lbl_titulo=new JLabel();
        lbl_titulo.setFont(fuente);
        lbl_titulo.setText("Reproductor de audio");
        lbl_titulo.setForeground(Color.WHITE);
        panelsuperior.add(lbl_titulo);
        this.add(panelsuperior,BorderLayout.NORTH);
    }

    public void panelInferior(){
        panelinferior=new JPanel();
        lbl_lesup=new JLabel();
        lbl_lesup.setForeground(Color.WHITE);
        panelinferior.add(lbl_lesup);
        panelinferior.setBackground(new Color(182));
        panelinferior.setPreferredSize(new DimensionUIResource(1000,50));
        this.add(panelinferior,BorderLayout.SOUTH);
    }


    public void panelCentral(){
        panelcentral=new JPanel();
        panelcentral.setLayout(new BorderLayout());
        panelcentral.setBackground(Color.WHITE);
        portada=Toolkit.getDefaultToolkit().getImage("recursos/portada.jpg");
        btn_play=new JButton("Play");
        btn_play.addActionListener(this);
        btn_anterior=new JButton("Anterior");
        btn_anterior.addActionListener(this);
        btn_siguiente=new JButton("Siguiente");
        btn_siguiente.addActionListener(this);
        panelsubcentral=new JPanel();
        panelsubcentralsup=new JPanel();
        panelsubcentralsup.setBackground(new Color(345));
        panelsubcentralsup.setOpaque(true);
        lbl_leiz=new JLabel();
        Font fuente2= new Font("",5,25);
        lbl_leiz.setFont(fuente2);
        lbl_leiz.setForeground(Color.WHITE);
        panelsubcentralsup.add(lbl_leiz);
        panelsubcentralsup.setPreferredSize(new DimensionUIResource(200, 100));
        panelcentral.add(panelsubcentralsup,BorderLayout.NORTH);
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
        if (e.getSource()==btn_abrir) {
            //JTextField txtReproductor = new JTextField();
            lbl_leder=new JLabel(new ImageIcon("proyecto/recursos/portada1.jpeg"));
            lbl_leder.setPreferredSize(new DimensionUIResource(250,250));;
            panelcentral.add(lbl_leder,BorderLayout.CENTER);
            JFileChooser fc=new JFileChooser();
            int seleccion=fc.showOpenDialog(this);
            if(seleccion==JFileChooser.APPROVE_OPTION){
                File fichero=fc.getSelectedFile();
                txtReproductor=fichero.getAbsolutePath();
                lbl_lesup.setText(txtReproductor);
                lbl_leiz.setText(fichero.getName());
            }
        }
        if (e.getSource()==btn_play) {
            //Creamos el FileInputStream con la ruta del fichero de audio
            try(FileInputStream fis=new FileInputStream(txtReproductor)){
                //Creamos el objeto Player
                Player player=new Player(fis);
                //Reproducimos el fichero, una vez lo haga no podremos hacer nada hasta que termine<br /><br />
                player.play();
                //player.getPosition();
            }catch (JavaLayerException e1) {
                JOptionPane.showMessageDialog(this, "No es un fichero de audio");
            }catch (IOException ex) {
                ex.printStackTrace();
            }
 
        }
        
    }
    public static void main(String[] args) {
        Reproductor repro=new Reproductor();
    }
}
