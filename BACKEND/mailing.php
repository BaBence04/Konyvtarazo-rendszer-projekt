<?php
    // Import PHPMailer classes into the global namespace
    use PHPMailer\PHPMailer\PHPMailer;
    use PHPMailer\PHPMailer\Exception;

    // Load Composer's autoloader
    // require 'vendor/autoload.php';
    
    require 'PHPMailer.php';
    require 'SMTP.php';
    require "Exception.php";

    
    
    function SendEmail($recipient_name, $recipient_address, $email_subject, $email_html_body, $email_plain_text_body): void{
        // Create an instance of PHPMailer
        $mail = new PHPMailer(true);
        
        $our_email = file_get_contents("gmail_email.txt");
        $password = file_get_contents("app_password.txt");   

        try {
            // Server settings
            $mail->isSMTP();                                            // Send using SMTP
            $mail->Host       = 'smtp.gmail.com';                     // Set the SMTP server to send through
            $mail->SMTPAuth   = true;                                   // Enable SMTP authentication
            $mail->Username   = $our_email;               // SMTP username
            $mail->Password   = $password;
            $mail->SMTPSecure = PHPMailer::ENCRYPTION_STARTTLS;         // Enable TLS encryption
            $mail->Port       = 587;                                    // TCP port to connect to
            $mail->CharSet    = PHPMailer::CHARSET_UTF8;

            // Recipients
            $mail->setFrom($our_email, 'Könyvtározó szakdolgozat');      // Sender's email and name
            $mail->addAddress($recipient_address, $recipient_name); // Add a recipient
            // $mail->addReplyTo('info@example.com', 'Information');       // Reply-to address

            // Content
            $mail->isHTML(true);                                        // Set email format to HTML
            $mail->Subject = $email_subject;                     // Email subject
            $mail->Body    = $email_html_body; // HTML body
            $mail->AltBody = $email_plain_text_body;     // Plain text body for non-HTML clients

            // Send the email
            $mail->send();
            echo 'Message has been sent';
        } catch (Exception $e) {
            echo "Message could not be sent. Mailer Error: {$mail->ErrorInfo}";
        }
    }
?>