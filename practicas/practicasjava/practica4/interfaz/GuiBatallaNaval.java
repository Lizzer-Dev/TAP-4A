package interfaz;
import java.awt.FlowLayout;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextArea;
import javax.swing.plaf.DimensionUIResource;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Font;
import java.awt.GridLayout;
import comunicacion.Atendedor;
import comunicacion.DataBase;
import logica.Jugador;
import java.awt.event.*;
import java.io.IOException;
import java.net.UnknownHostException;
import java.sql.SQLException;
public class GuiBatallaNaval extends JFrame implements ActionListener{
    Jugador jugador1;
    JButton btn_1vs1,btn_1vSystem,btn_disparar,btn_guardar,btn_MostrarGan;
    JPanel panel_sup,panel_inf,panel_der,panel_izq, panel_c,panel_inf2,panel_sup2;
    JLabel title,statusbar,h1,h2,h3;
    JTextArea areaProp,areaContr,areaInfo;
    Atendedor jugAtendedor;
    DataBase db;
    int cont=0;
    public GuiBatallaNaval(){
        areaProp=new JTextArea();
        areaContr=new JTextArea("");
        initComponents();
        try {
            jugAtendedor=new Atendedor();
            
        } catch (IOException e){
            // TODO Auto-generated catch block
            e.printStackTrace();
        }
        jugAtendedor.iniciar();
        init();
        jugador1.my_Tablero.tableroContrincante(jugAtendedor.getTablero());
        jugAtendedor.setTableroCont(jugador1.my_Tablero.tableroProp);
        //initTab();
    }
    public void refresh(){
        areaProp.setText("");
        areaContr.setText("");
        areaProp.append(jugador1.my_Tablero.mostrarTableroProp());
        areaContr.append(jugador1.my_Tablero.mostrarTableroPropTiros());
    }
    public void initTab(){
        areaProp.setEditable(false);
        areaProp.setBackground(new Color(52, 152, 219));
        areaProp.setOpaque(true);
        areaProp.setForeground(Color.WHITE);
        areaContr.setEditable(false);
        areaContr.setBackground(new Color(52, 152, 219));
        areaContr.setOpaque(true);
        areaContr.setForeground(Color.WHITE);
        panel_c=new JPanel();
        panel_c.setPreferredSize(new DimensionUIResource(800,500));
        panel_c.setLayout(new BorderLayout(5,5));
        panel_c.setBackground(new Color(93, 109, 126));
        Font fuente= new Font("",3,20);
        jugador1.my_Tablero.llenarTablero();
        panel_inf2=new JPanel();
        panel_inf2.setLayout(new BorderLayout());
        areaProp.append(jugador1.my_Tablero.mostrarTableroProp());
        panel_inf2.add(areaProp,BorderLayout.CENTER);
        JLabel lbl2=new JLabel("\tT A B L E R O    P R O P I O");
        lbl2.setFont(fuente);
        lbl2.setBackground(new Color(33, 47, 61));
        lbl2.setOpaque(true);
        lbl2.setForeground(Color.WHITE);
        panel_inf2.add(lbl2,BorderLayout.NORTH);
        panel_c.add(panel_inf2,BorderLayout.CENTER);
        jugador1.my_Tablero.mostrarTableroProp();
        jugador1.my_Tablero.tableroPropTiros();
        panel_sup2=new JPanel();
        panel_sup2.setLayout(new BorderLayout());
        areaContr.append(jugador1.my_Tablero.mostrarTableroPropTiros());
        panel_sup2.add(areaContr,BorderLayout.CENTER);
        JLabel lbl1=new JLabel("\tT A B L E R O    C O N T R I N C A N T E");
        lbl1.setFont(fuente);
        lbl1.setBackground(new Color(33, 47, 61));
        lbl1.setOpaque(true);
        lbl1.setForeground(Color.WHITE);
        panel_sup2.add(lbl1,BorderLayout.NORTH);
        panel_c.add(panel_sup2,BorderLayout.NORTH);
        this.add(panel_c,BorderLayout.WEST);
    }
    public void initComponents(){
        this.setTitle("BATALLA NAVAL");
        this.setSize(1100, 600);
        this.setBackground(new Color(28, 40, 51));
        this.setDefaultCloseOperation(EXIT_ON_CLOSE);
        this.setLocationRelativeTo(null);
        this.setLayout(new BorderLayout(5,5));
        panel_inf=new JPanel();
        panel_inf.setBackground(new Color(23, 32, 42));
        panel_inf.setPreferredSize(new DimensionUIResource(1100,50));
        this.add(panel_inf,BorderLayout.SOUTH);
        btn_disparar=new JButton("Disparar");
        btn_disparar.addActionListener(this);
        panel_inf.add(btn_disparar);
        panel_der=new JPanel();
        panel_der.setLayout(new BorderLayout(1,1));
        areaInfo=new JTextArea("¡A jugar!");
        areaInfo.setOpaque(true);
        areaInfo.setBackground(new Color(101, 130, 176));
        areaInfo.setEditable(false);
        areaInfo.setForeground(Color.white);;
        JLabel lb=new JLabel("Batalla Naval ");
        lb.setOpaque(true);
        lb.setBackground(new Color(101, 154, 241));
        Font fuente= new Font("",3,20);
        lb.setFont(fuente);
        panel_der.add(lb,BorderLayout.NORTH);
        panel_der.add(areaInfo,BorderLayout.CENTER);
        this.add(panel_der,BorderLayout.EAST);
        //__________________________________
        panel_sup=new JPanel();
        panel_sup.setBackground(new Color(14, 68, 157));
        panel_sup.setLayout(new FlowLayout());
        btn_1vSystem=new JButton("[1] vs [System]");
        btn_1vSystem.addActionListener(this);
        panel_sup.add(btn_1vSystem);
        btn_1vs1=new JButton("[1] vs [1]");
        btn_1vs1.addActionListener(this);
        panel_sup.add(btn_1vs1);
        btn_MostrarGan=new JButton("Ganadores");
        btn_MostrarGan.addActionListener(this);
        btn_MostrarGan.setEnabled(false);
        panel_sup.add(btn_MostrarGan);
        btn_guardar=new JButton("Guardar");
        btn_guardar.setEnabled(false);
        btn_guardar.addActionListener(this);
        panel_sup.add(btn_guardar);
        this.add(panel_sup,BorderLayout.NORTH);
    }    
    public void init(){
        try {
            jugador1=new Jugador(0);
            initTab();
            refresh();
            //new Atendedor(jugador1.tablero()).run();;
        } catch (UnknownHostException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        } catch (IOException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }
    }
    @Override
    public void actionPerformed(ActionEvent e) {
        // TODO Auto-generated method stub
        if (e.getSource()==btn_disparar) {
            areaInfo.setText("");
            jugador1.my_Tablero.efectuarDisparos();
            refresh();
            areaInfo.append(jugador1.nombre+" hizo 5 DISPAROS");
        }
        if(e.getSource()==btn_1vSystem){
            jugador1.my_Tablero.arribarBarco();
            refresh();
            db=new DataBase();
            db.conectar();
            try {
                db.crearTabla("JUGADORES");
            } catch (SQLException e1) {
                e1.printStackTrace();
            }
            btn_MostrarGan.setEnabled(true);
            btn_guardar.setEnabled(true);
        }
        if (e.getSource()==btn_guardar) {
            cont++;
            db.insert("JUGADORES","'"+cont+"',"+"'"+jugador1.nombre+"',"+"'"+jugador1.edad+"'");
        }
        if (e.getSource()==btn_MostrarGan) {
            areaInfo.setText("");
            areaInfo.append(db.select());
        }
        
    }
    public static void main(String[] args) {
        GuiBatallaNaval gui=new GuiBatallaNaval();
        gui.setVisible(true);
    }
}
