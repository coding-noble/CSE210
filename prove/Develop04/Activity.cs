internal abstract class Activity
{
    protected Random RandomGenorator { get; set; }
    protected DateTime ActivityStartTime { get; set; }
    protected string ActivityDescription { get; set; }
    protected string ActivityType { get; set; }
    protected int Duration { get; set; }
    public abstract void StartActivity();
    public Activity(string activityType, string activityDescription)
    {
        ActivityType = activityType;
        ActivityDescription = activityDescription;
        RandomGenorator = new Random();
    }
    protected void Welcome()
    {
        Console.Clear();
        Console.WriteLine($"""
        Welcome to the {ActivityType}

        {ActivityDescription}

        """);
        Console.Write("How long in seconds would you like this session: ");
        Duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.CursorVisible = false;
        Console.WriteLine("Get Ready...");
        WaitingAnimation(5);
    }
    protected void EndingMessage()
    {
        Console.WriteLine("\n\nWell Done!!!");
        WaitingAnimation(4);
        Console.WriteLine($"\nYou compleated {Duration} seconds of the {ActivityType.ToLower()}.");
        WaitingAnimation(6);
        Console.CursorVisible = true;
    }
    protected void WaitingAnimation(int cycleCount = 1)
    {
        int animationStartingLine = Console.CursorTop;
        string[] frames = { """
        ______________________________________________________________________
                                                                        ,--.  
                                                                         \  `.
        o  o  o  o  o  o  o  o  o  o  o  o  o  o  o  o  o  o  o  o  o  o /   ;
                                                                        '._,' 
        ______________________________________________________________________
        """, """
        ______________________________________________________________________
                                                                    ,--.      
                                                                   :__  `.    
          o  o  o  o  o  o  o  o  o  o  o  o  o  o  o  o  o  o  o  o /   ;    
                                                                    '._,'     
        ______________________________________________________________________
        """, """
        ______________________________________________________________________
                                                                ,--.          
                                                                 \  `.        
         o  o  o  o  o  o  o  o  o  o  o  o  o  o  o  o  o  o  o /   ;        
                                                                '._,'         
        ______________________________________________________________________
        """, """
        ______________________________________________________________________
                                                            ,--.              
                                                           :__  `.            
        o  o  o  o  o  o  o  o  o  o  o  o  o  o  o  o  o  o /   ;            
                                                            '._,'             
        ______________________________________________________________________
        """, """
        ______________________________________________________________________
                                                        ,--.                  
                                                         \  `.                
          o  o  o  o  o  o  o  o  o  o  o  o  o  o  o  o /   ;                
                                                        '._,'                 
        ______________________________________________________________________
        """, """
        ______________________________________________________________________
                                                    ,--.                      
                                                   :__  `.                    
         o  o  o  o  o  o  o  o  o  o  o  o  o  o  o /   ;                    
                                                    '._,'                     
        ______________________________________________________________________
        """, """
        ______________________________________________________________________
                                                ,--.                          
                                                 \  `.                        
        o  o  o  o  o  o  o  o  o  o  o  o  o  o /   ;                        
                                                '._,'                         
        ______________________________________________________________________
        """, """
        ______________________________________________________________________
                                            ,--.                              
                                           :__  `.                            
          o  o  o  o  o  o  o  o  o  o  o  o /   ;                            
                                            '._,'                             
        ______________________________________________________________________
        """, """
        ______________________________________________________________________
                                        ,--.                                  
                                         \  `.                                
         o  o  o  o  o  o  o  o  o  o  o /   ;                                
                                        '._,'                                 
        ______________________________________________________________________
        """, """
        ______________________________________________________________________
                                    ,--.                                      
                                   :__  `.                                    
        o  o  o  o  o  o  o  o  o  o /   ;                                    
                                    '._,'                                     
        ______________________________________________________________________
        """, """
        ______________________________________________________________________
                                ,--.                                          
                                 \  `.                                        
          o  o  o  o  o  o  o  o /   ;                                        
                                '._,'                                         
        ______________________________________________________________________
        """, """
        ______________________________________________________________________
                            ,--.                                              
                           :__  `.                                            
         o  o  o  o  o  o  o /   ;                                            
                            '._,'                                             
        ______________________________________________________________________
        """, """
        ______________________________________________________________________
                        ,--.                                                  
                         \  `.                                                
        o  o  o  o  o  o /   ;                                                
                        '._,'                                                 
        ______________________________________________________________________
        """, """
        ______________________________________________________________________
                    ,--.                                                      
                   :__  `.                                                    
          o  o  o  o /   ;                                                    
                    '._,'                                                     
        ______________________________________________________________________
        """, """
        ______________________________________________________________________
                ,--.                                                          
                 \  `.                                                        
         o  o  o /   ;                                                        
                '._,'                                                         
        ______________________________________________________________________
        """, """
        ______________________________________________________________________
            ,--.                                                              
           :__  `.                                                            
        o  o /   ;                                                            
            '._,'                                                             
        ______________________________________________________________________
        """, """
        ______________________________________________________________________
        ,--.                                                                  
         \  `.                                                                
         /   ;                                                                
        '._,'                                                                 
        ______________________________________________________________________
        """, """ 
        ______________________________________________________________________
                                                                              
                                                                              
                                                                              
                                                                              
        ______________________________________________________________________
        """ };
        for (int i = 0; i < cycleCount; i++)
        {
            foreach (string frame in frames)
            {
                Console.Write(frame);
                Thread.Sleep(200);
                Console.SetCursorPosition(0, animationStartingLine);
            }
        }
        Console.Clear();
    }
    protected void NumberCountdown(int time)
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}