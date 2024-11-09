import { React, useState, useMemo } from 'react'
import axios from '../api/axios'
import { Button } from 'antd'
import { DeleteOutlined } from '@ant-design/icons';

const DeleteButton = ({ productId, onDelete }) => {
    const [deletePending, setDeleteConfirmation] = useState(false);
    const [isSubmitting, setSubmitting] = useState(false);

    const buttonStatus = useMemo(() => {
        if (!deletePending)
            return "primary";
        else
            return "danger";
    }, [deletePending]);

    const handleDelete = async () => {
        if (!deletePending) {
            setDeleteConfirmation(true);

            setTimeout(() => {
                setDeleteConfirmation(false);
            }, 10000);

            return;
        }

        try {
            console.debug(`Запрос на удаление товара ${productId}`);
            setSubmitting(true);

            const response = await axios.delete(`/api/products/${productId}`);
            console.log(response);
            onDelete(productId);
        }
        catch (error) {
            console.error(error);
        }
        finally {
            setSubmitting(false);
        }
    };

    return (
        <Button variant="solid" color={buttonStatus} loading={isSubmitting} icon={< DeleteOutlined />} size="medium" onClick={handleDelete} />
    );
}

export default DeleteButton;