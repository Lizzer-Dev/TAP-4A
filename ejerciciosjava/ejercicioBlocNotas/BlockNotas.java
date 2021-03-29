package ejerciciosjava.ejercicioBlocNotas;
import java.awt.event.*;
import java.io.*;
import javax.swing.JButton;
import javax.swing.JFileChooser;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextPane;
import javax.swing.plaf.DimensionUIResource;
import javax.swing.text.BadLocationException;
import javax.swing.text.Document;
import javax.swing.text.SimpleAttributeSet;
import javax.swing.text.StyleConstants;

import java.awt.GridLayout;
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.Font;
public class BlockNotas extends JFrame implements ActionListener,MouseListener, MouseMotionListener, KeyListener{
    /**
     *
     */
    private static final long serialVersionUID = 1L;
    JButton btn_color;
    JButton btn_comillas;
    JButton btn_tamanio;
    JButton btn_abrir;
    JButton btn_guardar;
    JButton btn_salir;
    JButton btn_aumentar,btn_disminuir,btn_limpiar;
    JButton btn_rojo,btn_verde,btn_azul,btn_negro,btn_amarillo;
    JPanel panel1,panel2,panel3,panel4;
    JTextPane txt_in;
    JLabel lbl_actions;
    String name="Sin Titulo";
    boolean isClicked=false;
    boolean isClicked2=false;
    int tamanio=20;
    public BlockNotas(){
        initComponents();
    }
    public void initComponents(){
        this.addMouseListener(this);
        this.addMouseMotionListener(this);
        this.addKeyListener(this);
        this.setLocationRelativeTo(null);
        this.setDefaultCloseOperation(EXIT_ON_CLOSE);
        this.setTitle("Block De Notas");
        this.setSize(900,450);
        this.setVisible(true);
        this.setLayout(new BorderLayout(5,5));
        btn_abrir=new JButton("Abrir");
        btn_abrir.addActionListener(this);
        btn_color=new JButton("Cambiar color");
        btn_color.addActionListener(this);
        btn_comillas=new JButton("Agregar Comillas");
        btn_comillas.addActionListener(this);
        btn_guardar=new JButton("Guardar");
        btn_guardar.addActionListener(this);
        btn_salir= new JButton("Salir");
        btn_salir.addActionListener(this);
        btn_tamanio= new JButton("Cambiar Tamaño");
        btn_tamanio.addActionListener(this);
        btn_limpiar=new JButton("Nuevo");
        btn_limpiar.addActionListener(this);
        panel1=new JPanel();
        panel1.setBackground(Color.BLUE);
        panel1.setLayout(new FlowLayout());
        panel1.add(btn_limpiar);
        panel1.add(btn_guardar);
        panel1.add(btn_abrir);
        panel1.add(btn_color);
        panel1.add(btn_tamanio);
        panel1.add(btn_comillas);
        panel1.add(btn_salir);
        panel2=new JPanel();
        panel2.setBackground(Color.CYAN);
        lbl_actions=new JLabel("Mi block de notas");
        lbl_actions.setForeground(Color.BLACK);
        lbl_actions.setPreferredSize(new DimensionUIResource(800,30));
        panel2.setPreferredSize(new DimensionUIResource(800,35));
        panel2.add(lbl_actions);
        this.add(panel1,BorderLayout.NORTH);
        txt_in=new JTextPane();
        txt_in.setCaretColor(Color.BLUE);
        this.add(txt_in,BorderLayout.CENTER);
        this.add(panel2, BorderLayout.SOUTH);
        this.setBackground(Color.DARK_GRAY);
        txt_in.addMouseListener(this);
        txt_in.addKeyListener(this);
        panel3=new JPanel();
        panel3.setBackground(Color.BLUE);
        panel4=new JPanel();
        panel4.setBackground(Color.BLUE);
        btn_amarillo=new JButton("Amarillo");
        btn_amarillo.addActionListener(this);
        btn_rojo=new JButton("Rojo");
        btn_rojo.addActionListener(this);
        btn_negro=new JButton("Negro");
        btn_negro.addActionListener(this);
        btn_verde=new JButton("Verde");
        btn_verde.addActionListener(this);
        btn_azul=new JButton("Azul");
        btn_azul.addActionListener(this);
        btn_aumentar=new JButton("Aumentar");
        btn_aumentar.addActionListener(this);
        btn_disminuir=new JButton("Disminuir");
        btn_disminuir.addActionListener(this);
        panel3.setLayout(new GridLayout(2,0));
        panel4.setLayout(new GridLayout(5,0));
        panel3.add(btn_aumentar,1,0);
        panel3.add(btn_disminuir,2,0);
        panel4.add(btn_amarillo,1,0);
        panel4.add(btn_azul,2,0);
        panel4.add(btn_verde,3,0);
        panel4.add(btn_rojo,4,0);
        panel4.add(btn_negro,5,0);

    }
    public void guardar(){
        JFileChooser guardarcomo=new JFileChooser();
        guardarcomo.setApproveButtonText("Guardar");
        guardarcomo.showSaveDialog(null);
        File archivo=new File(guardarcomo.getSelectedFile()+".txt");
        try {
            BufferedWriter salida= new BufferedWriter(new FileWriter(archivo));
            salida.write(txt_in.getText());
            salida.close();
        } catch (Exception e) {
            //TODO: handle exception
        }
        name=archivo.getName();
    }

    public void abrir(){
        JFileChooser explorador= new JFileChooser();
        explorador.showOpenDialog(explorador);
        try {
            String patch= explorador.getSelectedFile().getAbsolutePath();
            FileInputStream archivo=new FileInputStream(patch);
            DataInputStream entrada=new DataInputStream(archivo);
            BufferedReader buffer=new BufferedReader(new InputStreamReader(entrada));
            name=explorador.getSelectedFile().getName();
            String txt=buffer.readLine();
            txt_in.setText(txt);

        } catch (Exception e) {
            JOptionPane.showMessageDialog(null,"Ocurrio un error");
        }
    }
    public static void main(String[] args) {
        BlockNotas notas= new BlockNotas();
    }

    @Override
    public void keyTyped(KeyEvent e) {
        // TODO Auto-generated method stub
        lbl_actions.setText("Tecleando: "+e.getKeyChar());
    }

    @Override
    public void keyPressed(KeyEvent e) {
        // TODO Auto-generated method stub
        
    }

    @Override
    public void keyReleased(KeyEvent e) {
        // TODO Auto-generated method stub
        
    }

    @Override
    public void mouseDragged(MouseEvent e) {
        // TODO Auto-generated method stub
        
        
    }

    @Override
    public void mouseMoved(MouseEvent e) {
        // TODO Auto-generated method stub
        
    }

    @Override
    public void mouseClicked(MouseEvent e) {
        // TODO Auto-generated method stub
        lbl_actions.setText("Archivo: [ "+name+" ] abierto");
    }

    @Override
    public void mousePressed(MouseEvent e) {
        // TODO Auto-generated method stub
        lbl_actions.setText("Archivo: [ "+name+" ] abierto");
    }

    @Override
    public void mouseReleased(MouseEvent e) {
        // TODO Auto-generated method stub
        
    }

    @Override
    public void mouseEntered(MouseEvent e) {
        // TODO Auto-generated method stub
        lbl_actions.setText("Bienvenido,Comience a editar el documento");
    }

    @Override
    public void mouseExited(MouseEvent e) {
        // TODO Auto-generated method stub
        lbl_actions.setText("Vuelva, comience a editar el documento");
    }

    @Override
    public void actionPerformed(ActionEvent arg0) {
        // TODO Auto-generated method stub
        if (arg0.getSource()==btn_limpiar) {
            guardar();
            name="Sin Titulo";
            txt_in.setText("");
        }
        if (arg0.getSource()==btn_salir) {
            dispose();
        }
        if (arg0.getSource()==btn_abrir) {
            abrir();
        }
        if (arg0.getSource()==btn_guardar){
            guardar();
        }
        if(arg0.getSource()==btn_aumentar) {
            if(tamanio<100) {
                tamanio+=5;
                Font fuente= new Font("",3,tamanio);
                txt_in.setFont(fuente);
                lbl_actions.setText("Aumentando tamaño de fuente a: "+tamanio);
            }else{
                lbl_actions.setForeground(Color.RED);
                lbl_actions.setText("Imposible aumentar más de tamaño de letra");
            }
        }
        if(arg0.getSource()==btn_disminuir) {
            if(tamanio>10) {
                tamanio=tamanio-5;
                Font fuente= new Font("",3,tamanio);
                txt_in.setFont(fuente);
                lbl_actions.setText("Disminuyendo tamaño de fuente a: "+tamanio);
            }else{
                lbl_actions.setForeground(Color.RED);
                lbl_actions.setText("Imposible disminuir más de tamaño de letra");
            }
        }
        
        if (arg0.getSource()==btn_tamanio) {
            if (isClicked2) {
                this.remove(panel4);
                isClicked2=!isClicked2;
            }if(!isClicked){
                this.add(panel3,BorderLayout.EAST);
            }else{
                this.remove(panel3);
            }
            isClicked=!isClicked;
            
        }
        if (arg0.getSource()==btn_azul) {
            if (txt_in.getSelectedText()!=null) {
                SimpleAttributeSet attributeSet = new SimpleAttributeSet();  
                attributeSet = new SimpleAttributeSet();  
                StyleConstants.setBold(attributeSet, true);  
                StyleConstants.setForeground(attributeSet, Color.BLUE);  
                Document doc = txt_in.getStyledDocument(); 
                int i=txt_in.getSelectionStart();
                try {
                    doc.insertString(i,txt_in.getSelectedText(), attributeSet);
                    
                } catch (BadLocationException e) {
                    // TODO Auto-generated catch block
                    e.printStackTrace();
                }
                txt_in.replaceSelection("");
                lbl_actions.setText("Cambiando color a : [ "+txt_in.getSelectedText()+" ]");
            }else{
                txt_in.setForeground(Color.BLUE);
                lbl_actions.setText("Cambiando color");
            }
        }
        if (arg0.getSource()==btn_verde) {
            if (txt_in.getSelectedText()!=null) {
                SimpleAttributeSet attributeSet = new SimpleAttributeSet();  
                attributeSet = new SimpleAttributeSet();  
                StyleConstants.setBold(attributeSet, true);  
                StyleConstants.setForeground(attributeSet, Color.GREEN);  
                Document doc = txt_in.getStyledDocument(); 
                int i=txt_in.getSelectionStart();
                try {
                    doc.insertString(i,txt_in.getSelectedText(), attributeSet);
                    
                } catch (BadLocationException e) {
                    // TODO Auto-generated catch block
                    e.printStackTrace();
                }
                txt_in.replaceSelection("");
                lbl_actions.setText("Cambiando color a : [ "+txt_in.getSelectedText()+" ]");
            }else{
                txt_in.setForeground(Color.GREEN);
                lbl_actions.setText("Cambiando color");
            }
        }
        if (arg0.getSource()==btn_negro) {
            if (txt_in.getSelectedText()!=null) {
                SimpleAttributeSet attributeSet = new SimpleAttributeSet();  
                attributeSet = new SimpleAttributeSet();  
                StyleConstants.setBold(attributeSet, true);  
                StyleConstants.setForeground(attributeSet, Color.BLACK);  
                Document doc = txt_in.getStyledDocument(); 
                int i=txt_in.getSelectionStart();
                try {
                    doc.insertString(i,txt_in.getSelectedText(), attributeSet);
                    
                } catch (BadLocationException e) {
                    // TODO Auto-generated catch block
                    e.printStackTrace();
                }
                txt_in.replaceSelection("");
                lbl_actions.setText("Cambiando color a : [ "+txt_in.getSelectedText()+" ]");
            }else{
                txt_in.setForeground(Color.BLACK);
                lbl_actions.setText("Cambiando color");
            }
        }
        if (arg0.getSource()==btn_rojo) {
            if (txt_in.getSelectedText()!=null) {
                SimpleAttributeSet attributeSet = new SimpleAttributeSet();  
                attributeSet = new SimpleAttributeSet();  
                StyleConstants.setBold(attributeSet, true);  
                StyleConstants.setForeground(attributeSet, Color.RED);  
                Document doc = txt_in.getStyledDocument(); 
                int i=txt_in.getSelectionStart();
                try {
                    doc.insertString(i,txt_in.getSelectedText(), attributeSet);
                    
                } catch (BadLocationException e) {
                    // TODO Auto-generated catch block
                    e.printStackTrace();
                }
                txt_in.replaceSelection("");
                lbl_actions.setText("Cambiando color a : [ "+txt_in.getSelectedText()+" ]");
            }else{
                txt_in.setForeground(Color.RED);
                lbl_actions.setText("Cambiando color");
            }
        }
        if (arg0.getSource()==btn_amarillo) {
            if (txt_in.getSelectedText()!=null) {
                SimpleAttributeSet attributeSet = new SimpleAttributeSet();  
                attributeSet = new SimpleAttributeSet();  
                StyleConstants.setBold(attributeSet, true);  
                StyleConstants.setForeground(attributeSet, Color.YELLOW);  
                Document doc = txt_in.getStyledDocument(); 
                int i=txt_in.getSelectionStart();
                try {
                    doc.insertString(i,txt_in.getSelectedText(), attributeSet);
                    
                } catch (BadLocationException e) {
                    // TODO Auto-generated catch block
                    e.printStackTrace();
                }
                txt_in.replaceSelection("");
                lbl_actions.setText("Cambiando color a : [ "+txt_in.getSelectedText()+" ]");
            }else{
                txt_in.setForeground(Color.YELLOW);
                lbl_actions.setText("Cambiando color");
            }
        }
        if(arg0.getSource()==btn_color){
            if (isClicked) {
                this.remove(panel3);
                isClicked=!isClicked;
            }if (!isClicked2) {
                this.add(panel4,BorderLayout.EAST);
            } else {
                this.remove(panel4);
            }
            isClicked2=!isClicked2;
        }

        if (arg0.getSource()==btn_comillas) {
            if (txt_in.getSelectedText()!=null) {
                lbl_actions.setText("Agregando comillas a : [ "+txt_in.getSelectedText()+" ]");
                txt_in.replaceSelection("\""+txt_in.getSelectedText()+"\"");
            }else{
                JOptionPane.showMessageDialog(null,"Debe selecionar un texto");
            }
            
        }
    }
}
