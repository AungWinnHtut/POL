import socket
import sys

# Create a TCP/IP socket
sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

# Bind the socket to the port
server_address = ('192.168.1.2', 5000)
print('starting up on {} port {}'.format(*server_address))
sock.bind(server_address)

# Listen for incoming connections
sock.listen(5)


while True:
    # Wait for a connection
    print('waiting for a connection')
    connection, client_address = sock.accept()
    try:

        data = connection.recv(1024)
        print('received {!r}'.format(data))
        if data:
            connection.sendall(data)
            print('sending data back to the client   10:15')
            if data == "Ready\r\n":
                print('if enter')
                connection.sendall(data)
                print('sending data back to the client   10:15')
            elif data == "Busy\r\n":
                print('controller busy')
                connection.sendall(data)
        else:
            print('no data from', client_address)
            break

    finally:
        # Clean up the connection
        connection.close()
    #sock.close()