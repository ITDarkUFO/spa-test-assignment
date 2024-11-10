import { useState } from 'react'
import axios from '../api/axios'

import { Button } from 'antd'
import { DeleteOutlined } from '@ant-design/icons';

import { useDataFetch } from '../context/DataFetchContext';

const DeleteButton = ({ productId }) => {
    const { dispatch } = useDataFetch();

    const [deletePending, setDeletePending] = useState(false);
    const [isDeletingProduct, setIsDeletingProduct] = useState(false);

    const showDeletePending = () => {
        setDeletePending(true);

        setTimeout(() => {
            setDeletePending(false);
        }, 10000);
    };

    const handleDelete = async (event) => {
        event.stopPropagation();

        if (!deletePending) {
            showDeletePending();
            return;
        }

        try {
            setIsDeletingProduct(true);

            console.log(`Запрос на удаление товара ${productId}`);
            const response = await axios.delete(`/api/products/${productId}`);
            console.log(response);

            dispatch({ type: 'TOGGLE_FETCH' });
        }
        catch (error) {
            console.error(error);
        }
        finally {
            setIsDeletingProduct(false);
        }
    };

    return (
        <Button type="primary" size="medium" icon={< DeleteOutlined />}
            danger={deletePending} loading={isDeletingProduct} onClick={handleDelete} />
    );
}

export default DeleteButton;