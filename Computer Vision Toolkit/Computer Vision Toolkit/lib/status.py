import sys
import os

#--------------------------------------------------------------------------------------------------------
#--------------------------------------------------------------------------------------------------------
#--------------------------------------------------------------------------------------------------------
#--------------------------------------------------------------------------------------------------------
#--------------------------------------------------------------------------------------------------------

#Outputs backend stsatus to the frontend
def status(flag, in_str=None):

    if flag is None or in_str is None:
        return

    if flag == '-i-':	#Initialization
        print("{0} {1}".format( flag, in_str ))

    if flag == '-d-':	#Detected
        print("{0} {1} {2:.6f} sec {3:.6f}%".format( flag, in_str[0], in_str[1], in_str[2]) )

    if flag == '-o-':	#Other
        print("{0} {1} {2:.6f} sec {3:.6f}%".format( flag, in_str[0], in_str[1], in_str[2]) )

    if flag == '-m-':	#Modified Original
        print("{0} {1} {2:.6f} sec {3}".format( flag, in_str[0], in_str[1], in_str[2]) )

    if flag == '-v-':
        print("{0} {1} {2:.6f} sec {3:.6f}%".format( flag, in_str[0], in_str[1], in_str[2]) )

    if flag == '-f-':   #Finished
        print('-f- Finished Image Analysis...\n')
        print("\n{0} image(s) analyzed\n".format( in_str[1] ))
        if in_str[1] > 0:
            print("Average elapsed time: {0:.3f} sec".format( (in_str[0] ) / in_str[1] ) )
        print("Total elapsed time: {0:.3f} sec\n".format( in_str[0] ) )

    if flag == '-e-':	#Error
        print('-e- ')
        print("Exception occurred in analyze.py: \n")
        print( in_str + "\n")

    sys.stdout.flush()
    return


#--------------------------------------------------------------------------------------------------------

def log(fd, flag=None, in_str=None):
    
    if in_str is None:
        return

    if flag is None:
        fd.write(in_str)

    if flag == '-i-':	#Initialization
        fd.write("{0} {1}\n".format( flag, in_str ))

    if flag == '-d-':	#Detected
        fd.write("{0} {1} {2:.6f} {3:.6f}\n".format( flag, in_str[0], in_str[1], in_str[2]) )

    if flag == '-o-':	#Other
        fd.write("{0} {1} {2:.6f} {3:.6f}\n".format( flag, in_str[0], in_str[1], in_str[2]) )

    if flag == '-m-':	#Modified Original
        fd.write("{0} {1} {2:.6f} {3}\n".format( flag, in_str[0], in_str[1], in_str[2]) )

    if flag == '-v-':	#Video
        fd.write("{0} {1} {2:.6f} {3:.6f}\n".format( flag, in_str[0], in_str[1], in_str[2]) )

    if flag == '-f-':   #Finished
        fd.write('-f- Finished Image Analysis...\n')
        fd.write("\n{0} image(s) analyzed\n".format( in_str[1] ))
        if in_str[1] > 0:
            fd.write("Average elapsed time: {0:.3f} sec\n".format( (in_str[0] ) / in_str[1] ) )
        fd.write("Total elapsed time: {0:.3f} sec\n".format( in_str[0] ) )

    if flag == '-e-':	#Error
        fd.write("-e- Exception occurred in analyze.py: ")
        fd.write( in_str + "\n")

    sys.stdout.flush()
    fd.flush()
    return


#--------------------------------------------------------------------------------------------------------
#--------------------------------------------------------------------------------------------------------
#--------------------------------------------------------------------------------------------------------
