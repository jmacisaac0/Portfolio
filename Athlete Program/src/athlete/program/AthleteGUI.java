
package athlete.program;

import java.util.*;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

/**
 *
 * @author Julian MacIsaac
 */
public class AthleteGUI extends JFrame implements ActionListener {
    
    //Constants
    private enum ProfessionalType { LAWYER, ASSISTANT, AGENT, TRAINER; }
    private static final String[] PROFESSIONAL_LIST = 
                            { "Lawyer", "Assistant", "Agent", "Trainer"};
    private static final double[] PAYMENT_COEFFICIENTS = { 0.1, 0.03, 0.07, 0.05 };
    private static final Dimension GROUP_SPACING = new Dimension( 50, 50 );
    
    //Member Variables
    String athleteName;
    int athleteSalary;
    
    //Objects
    HashMap<Integer, Professional> professionalMap;
    ArrayList<String> exceptionLog;
    
    //GUI Objects
    Container contentPane;
    JPanel athleteInputPnl, professionInputPnl, outputPnl;
    JLabel athleteNameLbl, athleteSalaryLbl, professionalNameLbl,
            professionalTypeLbl;
    JTextField athleteNameTxt, athleteSalaryTxt, professionalNameTxt;
    JButton submitAthleteBtn, clearAthleteBtn, addProfessionalBtn, 
            clearProfessionalBtn;
    JComboBox professionalTypeBox;
    JTextArea outputArea;
    
    //Constructors
    
    public AthleteGUI() {
        
        professionalMap = new HashMap<>();
        exceptionLog = new ArrayList<>();
        
    }
    
    //Methods
    
    public void initialize() {
        
        this.setTitle("Athlete Program");
        this.setLocationRelativeTo(null);
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        
        contentPane = getContentPane();
        contentPane.setLayout(new BoxLayout(contentPane, BoxLayout.PAGE_AXIS));
        
        athleteInputPnl = new JPanel();
        athleteInputPnl.setLayout(new GridLayout(3, 2, 10, 10));      
        athleteNameLbl = new JLabel("Enter name of athlete: ");
        athleteSalaryLbl = new JLabel("Enter salary of athlete: ");
        athleteNameTxt = new JTextField();
        athleteSalaryTxt = new JTextField();
        submitAthleteBtn = new JButton("Submit");
        submitAthleteBtn.addActionListener(this);
        clearAthleteBtn = new JButton("Clear");
        clearAthleteBtn.setActionCommand("Clear Athlete Fields");
        clearAthleteBtn.addActionListener(this);
        athleteInputPnl.add(athleteNameLbl);
        athleteInputPnl.add(athleteNameTxt);
        athleteInputPnl.add(athleteSalaryLbl);
        athleteInputPnl.add(athleteSalaryTxt);
        athleteInputPnl.add(submitAthleteBtn);
        athleteInputPnl.add(clearAthleteBtn);
        contentPane.add(athleteInputPnl);
        
        contentPane.add(Box.createRigidArea(GROUP_SPACING));
        
        professionInputPnl = new JPanel();
        professionInputPnl.setLayout( new GridLayout( 3, 2, 10, 10 ));
        professionalNameLbl = new JLabel("Enter name of new professional: ");
        professionalTypeLbl = new JLabel("Select profession: ");
        professionalNameTxt = new JTextField();
        professionalNameTxt.setEditable( false );
        professionalTypeBox = new JComboBox(PROFESSIONAL_LIST);
        professionalTypeBox.setEnabled( false );
        addProfessionalBtn = new JButton("Add");
        addProfessionalBtn.addActionListener( this );
        addProfessionalBtn.setEnabled( false );
        clearProfessionalBtn = new JButton("Clear");
        clearProfessionalBtn.setActionCommand("Clear Professional Fields");
        clearProfessionalBtn.addActionListener( this );
        clearProfessionalBtn.setEnabled( false );
        professionInputPnl.add( professionalNameLbl );
        professionInputPnl.add( professionalNameTxt );
        professionInputPnl.add( professionalTypeLbl );
        professionInputPnl.add( professionalTypeBox );
        professionInputPnl.add( addProfessionalBtn );
        professionInputPnl.add( clearProfessionalBtn );
        contentPane.add(professionInputPnl);
        
        contentPane.add(Box.createRigidArea(GROUP_SPACING));
        
        outputPnl = new JPanel();
        outputPnl.setLayout(new BoxLayout(outputPnl, BoxLayout.PAGE_AXIS));
        outputArea = new JTextArea("Enter the athlete's information.", 10, 1);
        outputArea.setTabSize(4);
        outputArea.setEditable(false);
        outputPnl.add(outputArea);
        contentPane.add(outputPnl);
        
        this.setVisible(true);
        this.pack();
    }
    @Override
    public void actionPerformed(ActionEvent e) {
        
        String ac = e.getActionCommand();
        
        switch (ac) {
            case "Submit":
                submitAthleteBtn.setEnabled( false );
                clearAthleteBtn.setEnabled( false );
                athleteNameTxt.setEditable( false );
                athleteSalaryTxt.setEditable( false );
                professionalNameTxt.setEditable( true );
                professionalTypeBox.setEnabled( true );
                addProfessionalBtn.setEnabled( true );
                clearProfessionalBtn.setEnabled( true );
                break;
            case "Add":
                break;
            case "Clear Athlete Fields":
                athleteNameTxt.setText( "" );
                athleteSalaryTxt.setText( "" );
                break;
            case "Clear Professional Fields":
                professionalNameTxt.setText( "" );
                break;
            default:
                break;
        }
        
        this.pack();
    }
    public void printExceptionLog() {
        
        for (String e : exceptionLog) {
            
        }
        
    }
    
    
    //Professional Class
    
    private class Professional {
        
        int type;
        String name;
        
        public Professional(String name, int type) {
            initialize(name, type);
        }
        
        public void setType(int type) {
            if (type >= 0 && type < PAYMENT_COEFFICIENTS.length)
                this.type = type;
            else 
                exceptionLog.add("ERROR: setType() in Professional class");
        }
        public void setName(String name) {
            if (!name.equals(""))
                this.name = name;
            else
                exceptionLog.add("Please enter a name.");
        }
        public int getType() {
            return this.type;
        }
        public String getName() {
            return this.name;
        }
        
        private void initialize(String name, int type) {
            this.setType(type);
            this.setName(name);
        }
    }
}
